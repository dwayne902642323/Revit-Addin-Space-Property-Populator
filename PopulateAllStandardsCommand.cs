// Main external command class to bind shared parameters AND populate all space data
// Combines binding logic + population logic for complete automation

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;

namespace CSVToRevitSpaceUpdater
{
    [Transaction(TransactionMode.Manual)]
    public class PopulateAllStandardsCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string sharedParamPath = Path.Combine(desktop, "SharedParameters_Full_Standards.txt");

            if (!File.Exists(sharedParamPath))
            {
                TaskDialog.Show("Error", "Shared parameter file not found on Desktop.");
                return Result.Failed;
            }

            doc.Application.SharedParametersFilename = sharedParamPath;
            DefinitionFile defFile = doc.Application.OpenSharedParameterFile();
            if (defFile == null)
            {
                TaskDialog.Show("Error", "Failed to open shared parameter file.");
                return Result.Failed;
            }

            CategorySet spaceCategories = doc.Application.Create.NewCategorySet();
            spaceCategories.Insert(doc.Settings.Categories.get_Item(BuiltInCategory.OST_MEPSpaces));
            BindingMap bindingMap = doc.ParameterBindings;

            using (Transaction tx = new Transaction(doc, "Bind Shared Parameters"))
            {
                tx.Start();

                foreach (DefinitionGroup group in defFile.Groups)
                {
                    foreach (Definition def in group.Definitions)
                    {
                        if (def is ExternalDefinition definition && !bindingMap.Contains(definition))
                        {
                            InstanceBinding binding = doc.Application.Create.NewInstanceBinding(spaceCategories);
                            bindingMap.Insert(definition, binding, GroupTypeId.IdentityData);
                        }
                    }
                }

                tx.Commit();
            }

            string ashrae62 = Path.Combine(desktop, "ASHRAE62_1_Table6_2_2_1_Complete_All.csv");
            string imc = Path.Combine(desktop, "IMC_Table_403_3_1_1_Complete_All.csv");
            string heatGains = Path.Combine(desktop, "ASHRAE_Human_Activity_HeatRates.csv");
            string lpd = Path.Combine(desktop, "ASHRAE90_1_LPD_All_Space_Types_Final_Complete_All_Updated.csv");
            string plug = Path.Combine(desktop, "PlugLoadGuideline_ASAHRAE_DOE.csv");
            string ashrae170 = Path.Combine(desktop, "ASHRAE170_Table7_1_AllSpaces_Complete.csv");

            var ventilation = new VentilationAndExhaustEngine(ashrae62, imc);
            var heatEngine = new HeatGainEngine(heatGains);
            var lightPlugEngine = new LightingAndPlugLoadEngineV2(lpd, plug);
            var achEngine = new ACHAndPressureEngine(ashrae170);

            var allKeys = ventilation.GetAllKeys()
                .Union(heatEngine.GetAllKeys())
                .Union(lightPlugEngine.GetAllKeys())
                .Union(achEngine.GetAllKeys())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            var spaces = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_MEPSpaces)
                .WhereElementIsNotElementType()
                .Cast<Space>()
                .ToList();

            using (Transaction tx = new Transaction(doc, "Populate Space Parameters from Standards"))
            {
                tx.Start();

                foreach (var space in spaces)
                {
                    string matchKey = SpaceClassifier.Classify(space.Name, allKeys);

                    bool usedDefault = false;
                    if (string.IsNullOrEmpty(matchKey))
                    {
                        matchKey = "Office";
                        usedDefault = true;
                    }

                    SpaceReportingLogger.LogClassification(space.Name, matchKey, usedDefault);

                    SharedParameterWriter.SetParam(space, "SpaceFunction", matchKey);

                    ventilation.PopulateAllVentilationParams(space, matchKey);

                    var (sensible, latent, total, adjusted) = heatEngine.GetAllHeatGainValues(matchKey);
                    SharedParameterWriter.SetParam(space, "PeopleSensibleHeat", sensible);
                    SharedParameterWriter.SetParam(space, "PeopleLatentHeat", latent);
                    SharedParameterWriter.SetParam(space, "PeopleTotalHeat", total);
                    SharedParameterWriter.SetParam(space, "PeopleAdjustedTotalHeat", adjusted);

                    var (lpdVal, plugVal) = lightPlugEngine.GetLightingAndPlugLoad(matchKey);
                    SharedParameterWriter.SetParam(space, "LightingPowerDensity", lpdVal);
                    SharedParameterWriter.SetParam(space, "PlugLoadDensity", plugVal);

                    var (ach, oaAch, pressure, airClass) = achEngine.GetACHAndPressureInfo(matchKey);
                    SharedParameterWriter.SetParam(space, "MinTotalACH", ach);
                    SharedParameterWriter.SetParam(space, "MinOutdoorACH", oaAch);
                    SharedParameterWriter.SetParam(space, "PressureRelationship", pressure);
                    SharedParameterWriter.SetParam(space, "AirClass", airClass);

                    SpaceReportingLogger.LogUpdate(space, matchKey, new Dictionary<string, string>
                    {
                        {"SpaceFunction", matchKey},
                        {"LightingPowerDensity", lpdVal.ToString("F2")},
                        {"PlugLoadDensity", plugVal.ToString("F2")},
                        {"MinTotalACH", ach.ToString("F1")},
                        {"MinOutdoorACH", oaAch.ToString("F1")},
                        {"PressureRelationship", pressure},
                        {"AirClass", airClass},
                        {"PeopleSensibleHeat", sensible.ToString("F1")},
                        {"PeopleLatentHeat", latent.ToString("F1")},
                        {"PeopleTotalHeat", total.ToString("F1")},
                        {"PeopleAdjustedTotalHeat", adjusted.ToString("F1")}
                    });
                }

                tx.Commit();
            }

            SpaceReportingLogger.WriteToDesktop();
            TaskDialog.Show("Complete", $"Bound parameters and updated {spaces.Count} Revit spaces using standards-driven logic.");
            return Result.Succeeded;
        }
    }
}
