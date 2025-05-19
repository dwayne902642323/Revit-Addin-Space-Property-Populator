
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ASHRAE.SpaceOverrides
{
    public static class SpaceClassifier
    {
        public static string ClassifySpace(Space space)
        {
            string name = (space.Name ?? "").ToLowerInvariant();
            double area = space.Area;
            double height = (area > 0) ? space.Volume / area : 0;

            // --- ASHRAE 170 HIGH-PRIORITY SPACES ---
            if (name.Contains("operating")) return "170_Operating Room";
            if (name.Contains("patient") && name.Contains("isolation")) return "170_Isolation Room";
            if (name.Contains("patient") && name.Contains("exam")) return "170_Exam Room";
            if (name.Contains("icu") || name.Contains("intensive")) return "170_Intensive Care Room";
            if (name.Contains("nurse") && name.Contains("station")) return "170_Nurse Station";
            if (name.Contains("recovery")) return "170_Recovery Room";
            if (name.Contains("surgical") || name.Contains("or ")) return "170_Surgical Suite";
            if (name.Contains("imaging") || name.Contains("radiology")) return "170_Imaging Room";
            if (name.Contains("anesthesia")) return "170_Anesthetizing Location";
            if (name.Contains("soiled") || name.Contains("utility")) return "170_Soiled Workroom";
            if (name.Contains("clean") && name.Contains("work")) return "170_Clean Workroom";
            if (name.Contains("procedure")) return "170_Procedure Room";

            // --- 62.1 + IMC SHARED CLUSTERS ---
            if (name.Contains("office"))
            {
                if (area < 150) return "62IMC_Office Small";
                if (area <= 300) return "62IMC_Office Medium";
                return "62IMC_Office Large";
            }
            if (name.Contains("conference") || name.Contains("meeting")) return "62IMC_Conference Room";
            if (name.Contains("classroom")) return "62IMC_Classroom";
            if (name.Contains("lecture")) return "62IMC_Lecture Hall";
            if (name.Contains("restroom") || name.Contains("toilet")) return "62IMC_Restroom Public";
            if (name.Contains("bathroom")) return "62IMC_Restroom Private";
            if (name.Contains("storage")) return "62IMC_Storage Room";
            if (name.Contains("janitor")) return "62IMC_Janitor Closet";
            if (name.Contains("mechanical") || name.Contains("electrical")) return "62IMC_Mechanical Room";
            if (name.Contains("corridor") || name.Contains("hallway")) return "62IMC_Circulation";
            if (name.Contains("kitchen")) return "62IMC_Kitchen";
            if (name.Contains("dining")) return "62IMC_Dining Area";
            if (name.Contains("bar") || name.Contains("lounge")) return "62IMC_Bar Lounge";
            if (name.Contains("breakroom") || name.Contains("lounge")) return "62IMC_Break Room";
            if (name.Contains("locker")) return "62IMC_Locker Room";
            if (name.Contains("laboratory")) return "62IMC_Laboratory";
            if (name.Contains("pharmacy")) return "62IMC_Pharmacy";
            if (name.Contains("auditorium")) return "62IMC_Auditorium";
            if (name.Contains("theater")) return "62IMC_Theater";
            if (name.Contains("retail") || name.Contains("sales")) return "62IMC_Retail Floor";
            if (name.Contains("gym") || name.Contains("fitness")) return "62IMC_Fitness Center";
            if (name.Contains("arena") || name.Contains("sports")) return "62IMC_Sports Arena";
            if (name.Contains("transport") || name.Contains("terminal")) return "62IMC_Transport Facility";
            if (name.Contains("ticket")) return "62IMC_Ticketing Area";

            // --- ATRIUM special logic based on volume ---
            if (name.Contains("atrium"))
            {
                if (height < 20) return "62IMC_Atrium Low";
                else if (height <= 40) return "62IMC_Atrium Medium";
                else return "62IMC_Atrium High";
            }

            // --- DEFAULT FALLBACK ---
            return "Unclassified";
        }
    }
}