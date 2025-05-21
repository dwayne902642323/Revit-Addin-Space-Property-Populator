// Revit 2024+ Compatible: Create and bind shared parameters to MEP Spaces programmatically
// Dynamically creates definitions and binds them to the model using API

using System;
using System.IO;
using System.Linq;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;

namespace CSVToRevitSpaceUpdater
{
    [Transaction(TransactionMode.Manual)]
    public class BindSharedParameters : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            string sharedParamPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "SharedParameters_Full_Standards.txt");

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

            // Prepare categories
            CategorySet spaceCategories = doc.Application.Create.NewCategorySet();
            spaceCategories.Insert(doc.Settings.Categories.get_Item(BuiltInCategory.OST_MEPSpaces));
            BindingMap bindingMap = doc.ParameterBindings;

            int addedCount = 0;

            using (Transaction tx = new Transaction(doc, "Create + Bind Shared Parameters to Spaces"))
            {
                tx.Start();

                foreach (DefinitionGroup group in defFile.Groups)
                {
                    foreach (Definition def in group.Definitions)
                    {
                        if (def is ExternalDefinition definition)
                        {
                            if (bindingMap.Contains(definition))
                                continue;

                            InstanceBinding binding = doc.Application.Create.NewInstanceBinding(spaceCategories);
                            bool success = bindingMap.Insert(definition, binding, GroupTypeId.IdentityData);

                            if (success)
                                addedCount++;
                        }
                    }
                }

                tx.Commit();
            }

            TaskDialog.Show("Shared Parameters Bound",
                $"Successfully bound {addedCount} shared parameters to MEP Spaces.\nReady for auto-population.");

            return Result.Succeeded;
        }
    }
}
