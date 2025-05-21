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
    public static class SharedParameterWriter
    {
        public static void WriteVentilationParams(
            Space space,
            double ashraeRp,
            double ashraeRa,
            double combinedOutdoorAir,
            double ashraeDensity,
            double imcRp,
            double imcRa,
            double imcExhaust,
            double imcDensity)
        {
            // ASHRAE 62.1 Parameters
            SetParam(space, "PeopleOutdoorAirRp_CFM", ashraeRp);
            SetParam(space, "AreaOutdoorAirRa_CFM", ashraeRa);
            SetParam(space, "CombinedOutdoorAirRate_CFMPerPerson", combinedOutdoorAir);
            SetParam(space, "DefaultOccupantDensity", ashraeDensity);

            // IMC Parameters
            SetParam(space, "IMC_Rp_CFMPerPerson", imcRp);
            SetParam(space, "IMC_Ra_CFMPerFt2", imcRa);
            SetParam(space, "IMC_ExhaustCFMPerFt2", imcExhaust);
            SetParam(space, "IMC_OccupantDensity", imcDensity);
        }

        public static void WriteACHAndPressureParams(
            Space space,
            double minTotalACH,
            double minOutdoorACH,
            string pressureRelationship,
            string airClass)
        {
            SetParam(space, "MinTotalACH", minTotalACH);
            SetParam(space, "MinOutdoorACH", minOutdoorACH);
            SetParam(space, "PressureRelationship", pressureRelationship);
            SetParam(space, "AirClass", airClass);
        }

        public static void WriteHeatGainParams(
            Space space,
            double sensible,
            double latent,
            double total,
            double adjustedTotal)
        {
            SetParam(space, "PeopleSensibleHeat", sensible);
            SetParam(space, "PeopleLatentHeat", latent);
            SetParam(space, "PeopleTotalHeat", total);
            SetParam(space, "PeopleAdjustedTotalHeat", adjustedTotal);
        }

        public static void WriteLightingAndPlugLoadParams(
            Space space,
            double lightingPowerDensity,
            double plugLoadDensity)
        {
            SetParam(space, "LightingPowerDensity", lightingPowerDensity);
            SetParam(space, "PlugLoadDensity", plugLoadDensity);
        }

        public static void WriteClassification(Space space, string function)
        {
            SetParam(space, "SpaceFunction", function);
        }

        public static void SetParam(Element element, string paramName, double value)
        {
            Parameter param = element.LookupParameter(paramName);
            if (param != null && param.StorageType == StorageType.Double && !param.IsReadOnly)
                param.Set(value);
        }

        public static void SetParam(Element element, string paramName, string value)
        {
            Parameter param = element.LookupParameter(paramName);
            if (param != null && param.StorageType == StorageType.String && !param.IsReadOnly)
                param.Set(value);
        }

        public static void SetParam(Element element, string paramName, int value)
        {
            Parameter param = element.LookupParameter(paramName);
            if (param != null && param.StorageType == StorageType.Integer && !param.IsReadOnly)
                param.Set(value);
        }
    }
}
