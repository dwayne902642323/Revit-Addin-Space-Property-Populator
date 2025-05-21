// Loads sensible and latent heat gain per person from ASHRAE Fundamentals CSV
// Populates Revit shared parameters: PeopleSensibleHeat, PeopleLatentHeat

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVToRevitSpaceUpdater
{
    public class HeatGainEngine
    {
        private readonly Dictionary<string, Dictionary<string, string>> _heatGainTable;

        public HeatGainEngine(string csvPath)
        {
            _heatGainTable = LoadStandardTable(csvPath);
        }

        public (double sensible, double latent, double total, double adjusted) GetAllHeatGainValues(string spaceKey)
        {
            double sensible = 0, latent = 0, total = 0, adjusted = 0;

            if (_heatGainTable.TryGetValue(spaceKey, out var row))
            {
                sensible = TryParse(row.TryGetValue("PeopleSensibleHeat", out var s) ? s : null);
                latent = TryParse(row.TryGetValue("PeopleLatentHeat", out var l) ? l : null);
                total = TryParse(row.TryGetValue("PeopleTotalHeat", out var t) ? t : null);
                adjusted = TryParse(row.TryGetValue("PeopleAdjustedTotalHeat", out var a) ? a : null);
            }

            return (sensible, latent, total, adjusted);
        }


        public (double Sensible, double Latent) GetHeatGainPerPerson(string spaceKey)
        {
            double sensible = 0;
            double latent = 0;

            if (_heatGainTable.TryGetValue(spaceKey, out var row))
            {
                sensible = TryParse(row.TryGetValue("PeopleSensibleHeat", out var sens) ? sens : null);
                latent = TryParse(row.TryGetValue("PeopleLatentHeat", out var lat) ? lat : null);
            }

            return (sensible, latent);
        }

        public IEnumerable<string> GetAllKeys()
        {
            return _heatGainTable.Keys;
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
