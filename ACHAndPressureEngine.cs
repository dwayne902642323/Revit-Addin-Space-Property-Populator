// Loads ACH, pressure class, and air cleanliness classification from ASHRAE 170
// Returns ventilation and pressure-related design requirements

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVToRevitSpaceUpdater
{
    public class ACHAndPressureEngine
    {
        private readonly Dictionary<string, Dictionary<string, string>> _table;

        public ACHAndPressureEngine(string csvPath)
        {
            _table = LoadStandardTable(csvPath);
        }

        public (double MinACH, double MinOAACH, string PressureClass, string AirClass) GetACHAndPressureInfo(string spaceKey)
        {
            double minACH = 0, oaACH = 0;
            string pressure = "Neutral", airClass = "Class E";

            if (_table.TryGetValue(spaceKey, out var row))
            {
                minACH = TryParse(row.TryGetValue("MinTotalACH", out var ach) ? ach : null);
                oaACH = TryParse(row.TryGetValue("MinOutdoorACH", out var oa) ? oa : null);
                pressure = row.TryGetValue("PressureRelationship", out var p) ? p : "Neutral";
                airClass = row.TryGetValue("AirClass", out var ac) ? ac : "Class E";
            }

            return (minACH, oaACH, pressure, airClass);
        }

        public IEnumerable<string> GetAllKeys()
        {
            return _table.Keys;
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
