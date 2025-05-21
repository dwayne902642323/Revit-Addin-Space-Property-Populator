// Core engine for matching Revit space names against known space types
// from uploaded standards and returning a standardized key for CSV lookup.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVToRevitSpaceUpdater
{
    public static class SpaceClassifier
    {
        // Matches a Revit space name against known keys from standards
        public static string Classify(string spaceName, IEnumerable<string> spaceTypeKeys)
        {
            string loweredName = spaceName.ToLowerInvariant().Trim();

            // 1. Exact match
            string exact = spaceTypeKeys.FirstOrDefault(k => k.Equals(spaceName, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(exact))
            {
                SpaceReportingLogger.LogInfo($"Exact match: \"{spaceName}\" -> \"{exact}\"");
                return exact;
            }

            // 2. Contains match
            foreach (string key in spaceTypeKeys)
            {
                if (loweredName.Contains(key.ToLowerInvariant()))
                {
                    SpaceReportingLogger.LogInfo($"Partial match: \"{spaceName}\" contains \"{key}\"");
                    return key;
                }
            }

            // 3. Token match
            var tokens = loweredName.Split(new[] { ' ', '-', '_', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                string match = spaceTypeKeys.FirstOrDefault(k => k.ToLowerInvariant().Contains(token));
                if (!string.IsNullOrEmpty(match))
                {
                    SpaceReportingLogger.LogInfo($"Token match: \"{token}\" found in \"{match}\"");
                    return match;
                }
            }

            // 4. Fallback
            SpaceReportingLogger.LogWarning($"No match for space: {spaceName}. Defaulting to Office (Open Plan).");
            return "Office (Open Plan)";
        }


        private static string Normalize(string input)
        {
            return input.ToLower().Replace("_", "").Replace("-", "").Replace(" ", "");
        }

    }
}

