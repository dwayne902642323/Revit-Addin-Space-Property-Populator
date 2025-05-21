using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Autodesk.Revit.DB.Mechanical;

namespace CSVToRevitSpaceUpdater
{
    public static class SpaceReportingLogger
    {
        private static readonly List<string> _reportLines = new List<string>();
        private static readonly List<string> _warnings = new List<string>();

        public static void LogUpdate(Space space, string matchKey, Dictionary<string, string> values)
        {
            var name = space.Name.Replace(",", ";");
            var number = space.Number.Replace(",", ";");
            var valueLine = string.Join(",", values.Values);
            _reportLines.Add($"{name},{number},{matchKey},{valueLine}");
        }

        public static void LogWarning(string spaceName)
        {
            _warnings.Add(spaceName);
        }

        public static void LogClassification(string revitName, string matchKey, bool usedDefault)
        {
            string line = $"{revitName},{matchKey},{(usedDefault ? "DEFAULTED" : "MATCHED")}";
            _reportLines.Add("CLASSIFICATION: " + line);
        }

        public static void LogInfo(string message)
        {
            _reportLines.Add("[INFO] " + message);
        }

        public static void WriteToDesktop()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            File.WriteAllLines(Path.Combine(desktop, "SpacePopulationReport.csv"), new[] {
                "Space Name,Space Number,Matched Key,Values..."
            }.Concat(_reportLines));

            if (_warnings.Any())
            {
                File.WriteAllLines(Path.Combine(desktop, "SpacePopulationWarnings.txt"), _warnings);
            }
        }
    }
}
