// Logic engine to apply ventilation and exhaust values based on ASHRAE 62.1 and IMC standards
// Sources: ASHRAE 62.1 and IMC tables from .csv input

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Autodesk.Revit.DB.Mechanical;

namespace CSVToRevitSpaceUpdater
{
    public class VentilationAndExhaustEngine
    {
        private readonly Dictionary<string, Dictionary<string, string>> _ashrae62;
        private readonly Dictionary<string, Dictionary<string, string>> _imc;

        public VentilationAndExhaustEngine(string ashraePath, string imcPath)
        {
            _ashrae62 = LoadStandardTable(ashraePath);
            _imc = LoadStandardTable(imcPath);
        }

        public void PopulateAllVentilationParams(Space space, string spaceKey)
        {
            var (ashraeRp, ashraeRa, combined, ashraeDensity, imcRp, imcRa, imcExh, imcDensity) = GetVentilationValues(spaceKey);

            SharedParameterWriter.SetParam(space, "PeopleOutdoorAirRp_CFM", ashraeRp);
            SharedParameterWriter.SetParam(space, "AreaOutdoorAirRa_CFM", ashraeRa);
            SharedParameterWriter.SetParam(space, "CombinedOutdoorAirRate_CFMPerPerson", combined);
            SharedParameterWriter.SetParam(space, "DefaultOccupantDensity", ashraeDensity);

            SharedParameterWriter.SetParam(space, "IMC_Rp_CFMPerPerson", imcRp);
            SharedParameterWriter.SetParam(space, "IMC_Ra_CFMPerFt2", imcRa);
            SharedParameterWriter.SetParam(space, "IMC_ExhaustCFMPerFt2", imcExh);
            SharedParameterWriter.SetParam(space, "IMC_OccupantDensity", imcDensity);
        }

        public (double ashraeRp, double ashraeRa, double combined, double ashraeDensity, double imcRp, double imcRa, double imcExh, double imcDensity) GetVentilationValues(string spaceKey)
        {
            double ashraeRp = TryParse(_ashrae62.TryGetValue(spaceKey, out var rowA) && rowA.TryGetValue("PeopleOutdoorAirRp_CFM", out var rpA) ? rpA : null);
            double ashraeRa = TryParse(_ashrae62.TryGetValue(spaceKey, out rowA) && rowA.TryGetValue("AreaOutdoorAirRa_CFM", out var raA) ? raA : null);
            double ashraeDensity = TryParse(_ashrae62.TryGetValue(spaceKey, out rowA) && rowA.TryGetValue("DefaultOccupantDensity", out var dA) ? dA : null);
            double combined = ashraeRp + ashraeRa;

            double imcRp = TryParse(_imc.TryGetValue(spaceKey, out var rowI) && rowI.TryGetValue("IMC_Rp_CFMPerPerson", out var rpI) ? rpI : null);
            double imcRa = TryParse(_imc.TryGetValue(spaceKey, out rowI) && rowI.TryGetValue("IMC_Ra_CFMPerFt2", out var raI) ? raI : null);
            double imcExh = TryParse(_imc.TryGetValue(spaceKey, out rowI) && rowI.TryGetValue("IMC_ExhaustCFMPerFt2", out var exh) ? exh : null);
            double imcDensity = TryParse(_imc.TryGetValue(spaceKey, out rowI) && rowI.TryGetValue("IMC_OccupantDensity", out var dI) ? dI : null);

            return (ashraeRp, ashraeRa, combined, ashraeDensity, imcRp, imcRa, imcExh, imcDensity);
        }


        public IEnumerable<string> GetAllKeys()
        {
            return _ashrae62.Keys.Union(_imc.Keys, StringComparer.OrdinalIgnoreCase).Distinct();
        }

        private double TryParse(string val)
        {
            return double.TryParse(val, out double result) ? result : 0.0;
        }

        private Dictionary<string, Dictionary<string, string>> LoadStandardTable(string path)
        {
            var result = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
            if (!File.Exists(path)) return result;

            var lines = File.ReadAllLines(path);
            if (lines.Length < 2) return result;

            var headers = lines[0].Split(',');
            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                if (parts.Length != headers.Length) continue;
                string key = parts[0].Trim();
                var row = new Dictionary<string, string>();
                for (int i = 1; i < headers.Length; i++)
                {
                    row[headers[i].Trim()] = parts[i].Trim();
                }
                result[key] = row;
            }
            return result;
        }
    }
}
