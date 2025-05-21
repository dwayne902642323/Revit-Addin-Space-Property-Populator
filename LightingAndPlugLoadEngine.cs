// Loads and returns lighting power density (LPD) and plug load values per space type
// Populates shared parameters: LightingPowerDensity and PlugLoadDensity

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVToRevitSpaceUpdater
{
    public class LightingAndPlugLoadEngineV2
    {
        private readonly Dictionary<string, Dictionary<string, string>> _lpdTable;
        private readonly Dictionary<string, Dictionary<string, string>> _plugLoadTable;

        public LightingAndPlugLoadEngineV2(string lpdPath, string plugLoadPath)
        {
            _lpdTable = LoadStandardTable(lpdPath);
            _plugLoadTable = LoadStandardTable(plugLoadPath);
        }

        public (double LPD, double PlugLoad) GetLightingAndPlugLoad(string spaceKey)
        {
            double lpd = TryParse(_lpdTable.TryGetValue(spaceKey, out var lpdRow) &&
                                  lpdRow.TryGetValue("LightingPowerDensity", out var lpdVal) ? lpdVal : null);

            double plug = TryParse(_plugLoadTable.TryGetValue(spaceKey, out var plugRow) &&
                                   plugRow.TryGetValue("PlugLoadDensity", out var plugVal) ? plugVal : null);

            return (lpd, plug);
        }

        public IEnumerable<string> GetAllKeys()
        {
            return _lpdTable.Keys.Union(_plugLoadTable.Keys, StringComparer.OrdinalIgnoreCase).Distinct();
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
