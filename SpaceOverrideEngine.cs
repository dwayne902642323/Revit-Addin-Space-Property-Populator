
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using System;
using System.Collections.Generic;
using System.Linq;
using ASHRAE.SpaceOverrides;
using Autodesk.Revit.UI;

namespace ASHRAE.SpaceOverrides
{
    public static class SpaceOverrideEngine
    {
        public static void ApplyStandardOverrides(Space space, Document doc)
        {
            string cluster = SpaceClassifier.ClassifySpace(space);
            double area = space.Area;
            double volume = space.Volume;
            double height = (area > 0) ? volume / area : 0;

            // PEOPLE GAINS
            int people = (int)Math.Ceiling((ASHRAEDataDictionaries.IMCVentilationRates.ContainsKey(cluster) &&
                ASHRAEDataDictionaries.IMCVentilationRates[cluster].ContainsKey("Occupant Density (#/1000 ft²)"))
                ? Convert.ToDouble(ASHRAEDataDictionaries.IMCVentilationRates[cluster]["Occupant Density (#/1000 ft²)"]) * area / 1000
                : area / 100);

            double pplSens = 245.0, pplLat = 200.0;
            if (ASHRAEDataDictionaries.HumanActivityHeatRates.ContainsKey(cluster))
            {
                var gains = ASHRAEDataDictionaries.HumanActivityHeatRates[cluster];
                if (gains.ContainsKey("Sensible Heat (Btu/h)")) pplSens = Convert.ToDouble(gains["Sensible Heat (Btu/h)"]);
                if (gains.ContainsKey("Latent Heat (Btu/h)")) pplLat = Convert.ToDouble(gains["Latent Heat (Btu/h)"]);
            }

            double peopleSensible = pplSens * people;
            double peopleLatent = pplLat * people;

            // LIGHTING GAINS
            double lightingW = 1.0;
            if (ASHRAEDataDictionaries.LightingPowerDensity.ContainsKey(cluster))
                lightingW = Convert.ToDouble(ASHRAEDataDictionaries.LightingPowerDensity[cluster]["LPD (W/ft²)"]);
            double lightingSensible = lightingW * area * 3.41;

            // PLUG LOAD GAINS
            double plugW = 1.0;
            if (ASHRAEDataDictionaries.PlugLoads_W_per_ft2.ContainsKey(cluster))
                plugW = ASHRAEDataDictionaries.PlugLoads_W_per_ft2[cluster];
            double plugSensible = plugW * area * 3.41;

            // Total Sensible Load
            double totalSensible = peopleSensible + lightingSensible + plugSensible;

            // Airflow by sensible load and ACH
            double airflow_sensible = totalSensible / (1.085 * 20);
            double airflow_ach = (6 * volume) / 60; // fallback 6 ACH
            double finalAirflow = Math.Max(airflow_sensible, airflow_ach);

            var saParam = space.LookupParameter("Design Supply Airflow");
            if (saParam != null) saParam.Set(finalAirflow);

            // Exhaust Airflow
            double exhaustCfm = 0;
            if (ASHRAEDataDictionaries.IMCVentilationRates.ContainsKey(cluster) &&
                ASHRAEDataDictionaries.IMCVentilationRates[cluster].ContainsKey("Exhaust Airflow Rate (cfm/ft²)"))
            {
                exhaustCfm = Convert.ToDouble(ASHRAEDataDictionaries.IMCVentilationRates[cluster]["Exhaust Airflow Rate (cfm/ft²)"]) * area;
            }
            else if (ASHRAEDataDictionaries.ASHRAE170SpaceDesignParams.ContainsKey(cluster) &&
                ASHRAEDataDictionaries.ASHRAE170SpaceDesignParams[cluster].ContainsKey("Minimum Exhaust ACH"))
            {
                double ach = Convert.ToDouble(ASHRAEDataDictionaries.ASHRAE170SpaceDesignParams[cluster]["Minimum Exhaust ACH"]);
                exhaustCfm = (ach * volume) / 60;
            }
            else
            {
                exhaustCfm = 0; // Explicitly zero if no standard requires exhaust
            }

            var eaParam = space.LookupParameter("Design Exhaust Airflow");
            if (eaParam != null) eaParam.Set(exhaustCfm);

            // People Gains Parameters
            var pplSensParam = space.LookupParameter("People Sensible Heat Gain");
            var pplLatParam = space.LookupParameter("People Latent Heat Gain");
            if (pplSensParam != null) pplSensParam.Set(peopleSensible);
            if (pplLatParam != null) pplLatParam.Set(peopleLatent);

            // Lighting Load Parameter
            var lightParam = space.LookupParameter("Lighting Load");
            if (lightParam != null) lightParam.Set(lightingW * area);

            TaskDialog.Show("Overrides Complete", $"Cluster: {cluster}\nPeople: {people}\nTotal Sensible: {totalSensible:F1} Btu/h\nSupply Airflow: {finalAirflow:F1} cfm\nExhaust Airflow: {exhaustCfm:F1} cfm");
        }
    }
}
