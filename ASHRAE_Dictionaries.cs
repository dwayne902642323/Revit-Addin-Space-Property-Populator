
// ASHRAE 90.1, 62.1, 170, IMC Data Dictionaries for Revit Add-ins

using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ASHRAE.SpaceOverrides
{
    public static class ASHRAEDataDictionaries
    {
        // ASHRAE Human Activity Heat Rates
        public static Dictionary<string, Dictionary<string, object>> HumanActivityHeatRates = new Dictionary<string, Dictionary<string, object>> {
  {"Seated at theater", "new Dictionary<string, object> {
    {"Location", "Theater""},
    {"Total Heat (Male, Btu/h)", "390"},
    {"Adjusted Total Heat (M/F, Btu/h)", "350"},
    {"Sensible Heat (Btu/h)", "245"},
    {"Latent Heat (Btu/h)", "105"},
    {"% Sensible Heat Radiant (Low V)", "60.0"},
    {"% Sensible Heat Radiant (High V)", "27.0"}
  } },
  {"Seated, very light work", "new Dictionary<string, object> {
    {"Location", "Offices, hotels, apartments""},
    {"Total Heat (Male, Btu/h)", "450"},
    {"Adjusted Total Heat (M/F, Btu/h)", "400"},
    {"Sensible Heat (Btu/h)", "245"},
    {"Latent Heat (Btu/h)", "155"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Moderately active office work", "new Dictionary<string, object> {
    {"Location", "Offices, hotels, apartments""},
    {"Total Heat (Male, Btu/h)", "475"},
    {"Adjusted Total Heat (M/F, Btu/h)", "450"},
    {"Sensible Heat (Btu/h)", "250"},
    {"Latent Heat (Btu/h)", "200"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Standing, light work; walking", "new Dictionary<string, object> {
    {"Location", "Department store; retail store""},
    {"Total Heat (Male, Btu/h)", "550"},
    {"Adjusted Total Heat (M/F, Btu/h)", "450"},
    {"Sensible Heat (Btu/h)", "250"},
    {"Latent Heat (Btu/h)", "200"},
    {"% Sensible Heat Radiant (Low V)", "58.0"},
    {"% Sensible Heat Radiant (High V)", "38.0"}
  } },
  {"Walking, standing", "new Dictionary<string, object> {
    {"Location", "Drug store, bank""},
    {"Total Heat (Male, Btu/h)", "550"},
    {"Adjusted Total Heat (M/F, Btu/h)", "500"},
    {"Sensible Heat (Btu/h)", "250"},
    {"Latent Heat (Btu/h)", "250"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Sedentary work", "new Dictionary<string, object> {
    {"Location", "Restaurant""},
    {"Total Heat (Male, Btu/h)", "490"},
    {"Adjusted Total Heat (M/F, Btu/h)", "550"},
    {"Sensible Heat (Btu/h)", "275"},
    {"Latent Heat (Btu/h)", "275"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Light bench work", "new Dictionary<string, object> {
    {"Location", "Factory""},
    {"Total Heat (Male, Btu/h)", "800"},
    {"Adjusted Total Heat (M/F, Btu/h)", "750"},
    {"Sensible Heat (Btu/h)", "275"},
    {"Latent Heat (Btu/h)", "475"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Moderate dancing", "new Dictionary<string, object> {
    {"Location", "Dance hall""},
    {"Total Heat (Male, Btu/h)", "900"},
    {"Adjusted Total Heat (M/F, Btu/h)", "850"},
    {"Sensible Heat (Btu/h)", "305"},
    {"Latent Heat (Btu/h)", "545"},
    {"% Sensible Heat Radiant (Low V)", "49.0"},
    {"% Sensible Heat Radiant (High V)", "35.0"}
  } },
  {"Walking 3 mph; light machine work", "new Dictionary<string, object> {
    {"Location", "Factory""},
    {"Total Heat (Male, Btu/h)", "1000"},
    {"Adjusted Total Heat (M/F, Btu/h)", "1000"},
    {"Sensible Heat (Btu/h)", "375"},
    {"Latent Heat (Btu/h)", "625"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Bowling", "new Dictionary<string, object> {
    {"Location", "Bowling alley""},
    {"Total Heat (Male, Btu/h)", "1500"},
    {"Adjusted Total Heat (M/F, Btu/h)", "1450"},
    {"Sensible Heat (Btu/h)", "580"},
    {"Latent Heat (Btu/h)", "870"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Heavy work", "new Dictionary<string, object> {
    {"Location", "Factory""},
    {"Total Heat (Male, Btu/h)", "1500"},
    {"Adjusted Total Heat (M/F, Btu/h)", "1450"},
    {"Sensible Heat (Btu/h)", "580"},
    {"Latent Heat (Btu/h)", "870"},
    {"% Sensible Heat Radiant (Low V)", "54.0"},
    {"% Sensible Heat Radiant (High V)", "19.0"}
  } },
  {"Heavy machine work; lifting", "new Dictionary<string, object> {
    {"Location", "Factory""},
    {"Total Heat (Male, Btu/h)", "1600"},
    {"Adjusted Total Heat (M/F, Btu/h)", "1600"},
    {"Sensible Heat (Btu/h)", "635"},
    {"Latent Heat (Btu/h)", "965"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
  {"Athletics", "new Dictionary<string, object> {
    {"Location", "Gymnasium""},
    {"Total Heat (Male, Btu/h)", "2000"},
    {"Adjusted Total Heat (M/F, Btu/h)", "1800"},
    {"Sensible Heat (Btu/h)", "710"},
    {"Latent Heat (Btu/h)", "1090"},
    {"% Sensible Heat Radiant (Low V)", "null"},
    {"% Sensible Heat Radiant (High V)", "null"}
  } },
};

        // ASHRAE 90.1 Lighting Power Density (LPD)
        public static Dictionary<string, Dictionary<string, object>> LightingPowerDensity = new Dictionary<string, Dictionary<string, object>> {
  {"Atrium <20 ft in height", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.32"}
  } },
  {"Atrium, >20 ft and â<40 ft in height", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.41"}
  } },
  {"Atrium >40 ft in height", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.51"}
  } },
  {"Audience Seating Area - Auditorium", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.57"}
  } },
  {"Audience Seating Area - Gymnasium", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.23"}
  } },
  {"Audience Seating Area - Motion picture theater", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.27"}
  } },
  {"Audience Seating Area - Performing arts theater", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.1"}
  } },
  {"Audience Seating Area - Sports arena", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.27"}
  } },
  {"Audience Seating Area - All other audience seating areas", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.23"}
  } },
  {"Banking Activity Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Classroom - Shop classroom", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.17"}
  } },
  {"Classroom - All other classrooms/lecture halls/training rooms", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.72"}
  } },
  {"Computer Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.75"}
  } },
  {"Conference/Meeting/Multipurpose Rooms", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.88"}
  } },
  {"Control/Editing Room or Booth", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.73"}
  } },
  {"Copy/Print Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Corridor", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.44"}
  } },
  {"Courtroom", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.08"}
  } },
  {"Dining Areas - Bar/lounge or leisure dining", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.76"}
  } },
  {"Dining Areas - Cafeteria or fast-food dining", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.36"}
  } },
  {"Dining Areas - Family dining", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.52"}
  } },
  {"Dining Areas - All other dining areas", new Dictionary<string, object> {
    {"LPD (W/ft^2)", '0.42"}
  } },
  {"Electrical/Mechanical Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.71"}
  } },
  {"Emergency Vehicle Garage", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.51"}
  } },
  {"Equipment Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.73"}
  } },
  {"Food Preparation Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.19"}
  } },
  {"Guest Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.41"}
  } },
  {"Laboratory - In or as a classroom", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.05"}
  } },
  {"Laboratory - All other laboratories", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.21"}
  } },
  {"Laundry/Washing Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.51"}
  } },
  {"Loading Dock, Interior", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.87"}
  } },
  {"Lobby - Elevator", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.64"}
  } },
  {"Lobby - Hotel", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.48"}
  } },
  {"Lobby - Motion picture theater", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.2"}
  } },
  {"Lobby - Performing arts theater", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.21"}
  } },
  {"Lobby - All other lobbies", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.8"}
  } },
  {"Locker Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.43"}
  } },
  {"Lounge/Breakroom - Motherâs/wellness room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.68"}
  } },
  {"Lounge/Breakroom - All other lounges/breakrooms", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.55"}
  } },
  {"Office <150 ft^2", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.73"}
  } },
  {"Office >150 and <300 ft^2", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.66"}
  } },
  {"Offices >300 ft^2", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Parking Garage - Daylight transition zone", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.06"}
  } },
  {"Parking Garage - All other parking and drive areas", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.11"}
  } },
  {"Pharmacy Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.59"}
  } },
  {"Restroom", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.74"}
  } },
  {"Sales Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.85"}
  } },
  {"Seating Area, General", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.21"}
  } },
  {"Security Screening - Transportation screening", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.93"}
  } },
  {"Security Screening - Transportation screening queue", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Security Screening - General", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.64"}
  } },
  {"Stairwell", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.47"}
  } },
  {"Storage Room <50 ftÂ²", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.49"}
  } },
  {"Storage Room â¥50 ftÂ²", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.35"}
  } },
  {"Vehicular Maintenance Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.59"}
  } },
  {"Workshop (including workshop classrooms)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.17"}
  } },
  {"Casino - Betting/sportsbook/keno/bingo area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.82"}
  } },
  {"Casino - High-limit game area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.68"}
  } },
  {"Casino - Slot machine/digital gaming area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.54"}
  } },
  {"Casino - Table games area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.09"}
  } },
  {"Convention Center - Exhibit Space", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.5"}
  } },
  {"Correctional Facilities - Audience seating area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Correctional Facilities - Classroom/lecture hall/training room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.74"}
  } },
  {"Correctional Facilities - Confinement cells", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.6"}
  } },
  {"Correctional Facilities - Dining area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.35"}
  } },
  {"Dormitory - Living Quarters", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.48"}
  } },
  {"Visually Impaired Facility - Chapel (used primarily by residents)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.58"}
  } },
  {"Visually Impaired Facility - Corridor (used primarily by residents)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.71"}
  } },
  {"Visually Impaired Facility - Dining (used primarily by residents)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.22"}
  } },
  {"Visually Impaired Facility - Lobby", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.44"}
  } },
  {"Visually Impaired Facility - Recreation room/common living room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.2"}
  } },
  {"Visually Impaired Facility - Restroom", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.96"}
  } },
  {"Fire Station - Sleeping Quarters", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.22"}
  } },
  {"Gymnasium/Fitness Center - Exercise area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.82"}
  } },
  {"Gymnasium/Fitness Center - Playing area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.82"}
  } },
  {"Health Care Facility - Control room (MRI/CT/radiology/PET)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.78"}
  } },
  {"Health Care Facility - Exam/treatment room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.33"}
  } },
  {"Health Care Facility - Hospital corridor", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.61"}
  } },
  {"Health Care Facility - Imaging room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.94"}
  } },
  {"Health Care Facility - Lounge", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.77"}
  } },
  {"Health Care Facility - Medical supply room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.56"}
  } },
  {"Health Care Facility - Nursery", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.87"}
  } },
  {"Health Care Facility - Nurseâs station", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.07"}
  } },
  {"Health Care Facility - Operating room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "2.31"}
  } },
  {"Health Care Facility - Patient room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.78"}
  } },
  {"Health Care Facility - Physical therapy room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.82"}
  } },
  {"Health Care Facility - Recovery room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.18"}
  } },
  {"Health Care Facility - Telemedicine", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.44"}
  } },
  {"Library - Reading area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.86"}
  } },
  {"Library - Stacks", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.18"}
  } },
  {"Manufacturing Facility - Detailed manufacturing area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.75"}
  } },
  {"Manufacturing Facility - Extra-high bay area (>50 ft floor-to-ceiling height)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.36"}
  } },
  {"Manufacturing Facility - High bay area (25 to 50 ft floor-to-ceiling height)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.24"}
  } },
  {"Manufacturing Facility - Low bay area (<25 ft floor-to-ceiling height)", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.85"}
  } },
  {"Museum - General exhibition area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.31"}
  } },
  {"Museum - Restoration area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.24"}
  } },
  {"Performing Arts Theater - Dressing Room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.39"}
  } },
  {"Post Office - Sorting Area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.71"}
  } },
  {"Religious Facility - Audience seating area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.72"}
  } },
  {"Religious Facility - Fellowship hall", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.5"}
  } },
  {"Religious Facility - Worship/pulpit/choir area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.75"}
  } },
  {"Retail Facilities - Dressing/fitting room", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.45"}
  } },
  {"Retail Facilities - Hair care", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.65"}
  } },
  {"Retail Facilities - Mall concourse", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.57"}
  } },
  {"Retail Facilities - Massage", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.81"}
  } },
  {"Retail Facilities - Nail care", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.75"}
  } },
  {"Sports Arena - Class I facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "2.86"}
  } },
  {"Sports Arena - Class II facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.98"}
  } },
  {"Sports Arena - Class III facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.29"}
  } },
  {"Sports Arena - Class IV facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.85"}
  } },
  {"Natatorium - Class I facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "2.2"}
  } },
  {"Natatorium - Class II facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.47"}
  } },
  {"Natatorium - Class III facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.99"}
  } },
  {"Natatorium - Class IV facility", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.59"}
  } },
  {"Transportation Facility - Airport hanger", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "1.36"}
  } },
  {"Transportation Facility - Baggage/carousel area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.28"}
  } },
  {"Transportation Facility - Concourse", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.49"}
  } },
  {"Transportation Facility - Passenger loading area", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.71"}
  } },
  {"Transportation Facility - Ticket counter", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.4"}
  } },
  {"Warehouse - Storage Area - Medium-to-bulky, palletized items", new Dictionary<string, object> {
    {"LPD (W/ft^2)", 0.33"}
  } },
  {"Warehouse - Storage Area - Smaller items, picking areas", new Dictionary<string, object> {
    {"LPD (W/ft^2)", "0.69"}
  } },
};

        // IMC Table 403.3.1.1 Ventilation Rates
        public static Dictionary<string, Dictionary<string, object>> IMCVentilationRates = new Dictionary<string, Dictionary<string, object>> {
  {"Booking/waiting", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "50"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Cells (without plumbing fixtures)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Cells (with plumbing fixtures)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 1.0}
  } },
  {"Day room", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "30"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Dining halls", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Guard stations", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "15"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Coin-operated dry cleaner", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 15.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Coin-operated laundries", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Commercial dry cleaner", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "30"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 30.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Commercial laundry", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 25.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Storage, pick up", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "30"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Art classroom", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.7}
  } },
  {"Auditoriums", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "150"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Classrooms (ages 5–8)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Classrooms (age 9 plus)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "35"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Computer lab", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Corridors", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Day care (through age 4)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Lecture classroom", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "65"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Lecture hall (fixed seats)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "150"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Locker/dressing rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.25}
  } },
  {"Media center", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Multiuse assembly", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Music/theater/dance", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "35"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Science laboratories", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 1.0}
  } },
  {"Smoking lounges", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 60.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Sports locker rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.5}
  } },
  {"Wood/metal shops", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.5}
  } },
  {"Bars, cocktail lounges", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Cafeteria, fast food", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Dining rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Kitchens (cooking)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.7}
  } },
  {"Bathrooms/toilet—private", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 50.0}
  } },
  {"Bedroom/living room", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Conference/meeting (hotels)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "50"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Dormitory sleeping areas", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Gambling casinos", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "120"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Lobbies/prefunction", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "30"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Multipurpose assembly", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "120"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Conference rooms (offices)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "50"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Main entry lobbies (offices)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Office spaces", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "5"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Reception areas", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "30"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Telephone/data entry", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "60"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Garages (multiple units)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.75}
  } },
  {"Kitchens (private dwelling)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 100.0}
  } },
  {"Living areas", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "First bedroom 2; each additional 1"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.35 ACH but not less than 15 cfm/person"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Toilet rooms and bathrooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 50.0}
  } },
  {"Corridors (public)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Courtrooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 1.0}
  } },
  {"Elevator car", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Legislative chambers", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "50"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Libraries", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Museums (children’s)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "40"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Museums/galleries", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "40"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Places of religious worship", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "120"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Shower room (per shower head)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 50.0}
  } },
  {"Smoking lounges (public)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 60.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Toilet rooms – public", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 70.0}
  } },
  {"Dressing rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.25}
  } },
  {"Mall common areas", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "40"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Sales", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "15"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Shipping and receiving", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "2"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Smoking lounges (retail)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 60.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Storage rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Warehouses", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Automotive motor-fuel dispensing stations", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 1.5}
  } },
  {"Barber", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.5}
  } },
  {"Beauty salons", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.6}
  } },
  {"Nail salons", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "25"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.6}
  } },
  {"Embalming room", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 2.0}
  } },
  {"Pet shops (animal areas)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.9}
  } },
  {"Supermarkets", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "8"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Bowling alleys (seating areas)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "40"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Disco/dance floors", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Game arcades", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "20"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Gym, stadium, arena (play area)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "7"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Health club/aerobics room", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "40"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Health club/weight room", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 20.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Ice arenas without combustion engines", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.3"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.5}
  } },
  {"Spectator areas", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "150"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Swimming pools (pool and deck area)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.48"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Repair garages, enclosed parking garages", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.75}
  } },
  {"Refrigerated warehouses/freezers", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Warehouses", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Auditoriums (see Education)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Lobbies", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "150"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Stages, studios", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "70"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 10.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Ticket booths", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "60"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Platforms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Transportation waiting", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "100"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 7.5},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Bank vaults/safe deposit", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "5"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Computer (without printing)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "4"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Copy, printing rooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "4"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.06"},
    {"Exhaust Airflow Rate (cfm/ft^2)", 0.5}
  } },
  {"Darkrooms", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", null},
    {"People Outdoor Airflow Rate Rp (cfm/person)", null},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", 1.0}
  } },
  {"Meat processing", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 15.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", null},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Pharmacy (prep. area)", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.18"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
  {"Photo studios", new Dictionary<string, object> {
    {"Occupant Density (#/1000 ft^2)", "10"},
    {"People Outdoor Airflow Rate Rp (cfm/person)", 5.0},
    {"Area Outdoor Airflow Rate Ra (cfm/ft^2)", "0.12"},
    {"Exhaust Airflow Rate (cfm/ft^2)", null}
  } },
};

        // ASHRAE 62.1 Table 6.2.2.1 Ventilation Rates
        public static Dictionary<string, Dictionary<string, object>> ASHRAE621VentilationRates = new Dictionary<string, Dictionary<string, object>> {
  {"Cell", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 10.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.9},
    {"Air Class", 2}
  } },
  {"Dayroom", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 30.0},
    {"Combined Outdoor Air Rate (cfm/person)", 7.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.5},
    {"Air Class", 1}
  } },
  {"Guard stations", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 15.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.5},
    {"Air Class", 1}
  } },
  {"Booking/waiting", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 50.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.4},
    {"Air Class", 2}
  } },
  {"Daycare (through age 4)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.6},
    {"Air Class", 2}
  } },
  {"Daycare sickroom", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.6},
    {"Air Class", 3}
  } },
  {"Classrooms (ages 5–8)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 15.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.4},
    {"Air Class", 1}
  } },
  {"Classrooms (age 9 plus)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 35.0},
    {"Combined Outdoor Air Rate (cfm/person)", 13.0},
    {"Combined Outdoor Air Rate (L/s·person)", 6.7},
    {"Air Class", 1}
  } },
  {"Lecture classroom", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 65.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.3},
    {"Air Class", 1}
  } },
  {"Lecture hall (fixed seats)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 150.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.0},
    {"Air Class", 1}
  } },
  {"Art classroom", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 19.0},
    {"Combined Outdoor Air Rate (L/s·person)", 9.5},
    {"Air Class", 2}
  } },
  {"Science laboratories", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.6},
    {"Air Class", 2}
  } },
  {"University/college laboratories", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.6},
    {"Air Class", 2}
  } },
  {"Wood/metal shop", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 19.0},
    {"Combined Outdoor Air Rate (L/s·person)", 9.5},
    {"Air Class", 2}
  } },
  {"Computer lab", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 15.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.4},
    {"Air Class", 1}
  } },
  {"Media center", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", "A"},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 15.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.4},
    {"Air Class", 1}
  } },
  {"Music/theater/dance", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 35.0},
    {"Combined Outdoor Air Rate (cfm/person)", 12.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.9},
    {"Air Class", 1}
  } },
  {"Multiuse assembly", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 100.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.1},
    {"Air Class", 1}
  } },
  {"Restaurant dining rooms", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 70.0},
    {"Combined Outdoor Air Rate (cfm/person)", 10.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.1},
    {"Air Class", 2}
  } },
  {"Cafeteria/fast-food dining", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 100.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.7},
    {"Air Class", 2}
  } },
  {"Bars, cocktail lounges", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 100.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.7},
    {"Air Class", 2}
  } },
  {"Kitchen (cooking)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 14.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.0},
    {"Air Class", 2}
  } },
  {"Break rooms", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 7.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.5},
    {"Air Class", 1}
  } },
  {"Coffee stations", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.0},
    {"Air Class", 1}
  } },
  {"Conference/meeting", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 50.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.1},
    {"Air Class", 1}
  } },
  {"Corridors", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", null},
    {"Rp (L/s·person)", null},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 1}
  } },
  {"Occupiable storage rooms for liquids or gels", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", "B"},
    {"Default Occupant Density (#/1000 ft²)", 2.0},
    {"Combined Outdoor Air Rate (cfm/person)", 65.0},
    {"Combined Outdoor Air Rate (L/s·person)", 32.5},
    {"Air Class", 2}
  } },
  {"Bedroom/living room", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 11.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.5},
    {"Air Class", 1}
  } },
  {"Barracks sleeping areas", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.0},
    {"Air Class", 1}
  } },
  {"Laundry rooms, central", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 2}
  } },
  {"Laundry rooms within dwelling units", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 1}
  } },
  {"Lobbies/prefunction", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 30.0},
    {"Combined Outdoor Air Rate (cfm/person)", 10.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.8},
    {"Air Class", 1}
  } },
  {"Multipurpose assembly", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 120.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 2.8},
    {"Air Class", 1}
  } },
  {"Breakrooms (office)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 50.0},
    {"Combined Outdoor Air Rate (cfm/person)", 7.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.5},
    {"Air Class", 1}
  } },
  {"Main entry lobbies", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 11.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.5},
    {"Air Class", 1}
  } },
  {"Occupiable storage rooms for dry materials", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 2.0},
    {"Combined Outdoor Air Rate (cfm/person)", 35.0},
    {"Combined Outdoor Air Rate (L/s·person)", 17.5},
    {"Air Class", 1}
  } },
  {"Office space", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 5.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 1}
  } },
  {"Reception areas", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 30.0},
    {"Combined Outdoor Air Rate (cfm/person)", 7.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.5},
    {"Air Class", 1}
  } },
  {"Telephone/data entry", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 60.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.0},
    {"Air Class", 1}
  } },
  {"Bank vaults/safe deposit", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 5.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 2}
  } },
  {"Banks or bank lobbies", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 15.0},
    {"Combined Outdoor Air Rate (cfm/person)", 12.0},
    {"Combined Outdoor Air Rate (L/s·person)", 6.0},
    {"Air Class", 1}
  } },
  {"Computer (not printing)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 4.0},
    {"Combined Outdoor Air Rate (cfm/person)", 20.0},
    {"Combined Outdoor Air Rate (L/s·person)", 10.0},
    {"Air Class", 1}
  } },
  {"Freezer and refrigerated spaces (<50°F)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.0},
    {"Ra (L/s·m²)", 0.0},
    {"Notes", "E"},
    {"Default Occupant Density (#/1000 ft²)", 0.0},
    {"Combined Outdoor Air Rate (cfm/person)", 0.0},
    {"Combined Outdoor Air Rate (L/s·person)", 0.0},
    {"Air Class", 2}
  } },
  {"General manufacturing (excl. heavy industrial)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 7.0},
    {"Combined Outdoor Air Rate (cfm/person)", 36.0},
    {"Combined Outdoor Air Rate (L/s·person)", 18.0},
    {"Air Class", 3}
  } },
  {"Pharmacy (prep. area)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 23.0},
    {"Combined Outdoor Air Rate (L/s·person)", 11.5},
    {"Air Class", 2}
  } },
  {"Photo studios", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 1}
  } },
  {"Shipping/receiving", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", "B"},
    {"Default Occupant Density (#/1000 ft²)", 2.0},
    {"Combined Outdoor Air Rate (cfm/person)", 70.0},
    {"Combined Outdoor Air Rate (L/s·person)", 35.0},
    {"Air Class", 2}
  } },
  {"Sorting, packing, light assembly", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 7.0},
    {"Combined Outdoor Air Rate (cfm/person)", 25.0},
    {"Combined Outdoor Air Rate (L/s·person)", 12.5},
    {"Air Class", 2}
  } },
  {"Telephone closets", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", null},
    {"Rp (L/s·person)", null},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.0},
    {"Ra (L/s·m²)", 0.0},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 1}
  } },
  {"Transportation waiting", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 100.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.1},
    {"Air Class", 1}
  } },
  {"Warehouses", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "B"},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 2}
  } },
  {"Auditorium seating area", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 150.0},
    {"Combined Outdoor Air Rate (cfm/person)", 5.0},
    {"Combined Outdoor Air Rate (L/s·person)", 2.7},
    {"Air Class", 1}
  } },
  {"Places of religious worship", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 120.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 2.8},
    {"Air Class", 1}
  } },
  {"Courtrooms", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 70.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 2.9},
    {"Air Class", 1}
  } },
  {"Legislative chambers", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 50.0},
    {"Combined Outdoor Air Rate (cfm/person)", 6.0},
    {"Combined Outdoor Air Rate (L/s·person)", 3.1},
    {"Air Class", 1}
  } },
  {"Libraries", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.5},
    {"Air Class", 1}
  } },
  {"Lobbies", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 150.0},
    {"Combined Outdoor Air Rate (cfm/person)", 5.0},
    {"Combined Outdoor Air Rate (L/s·person)", 2.7},
    {"Air Class", 1}
  } },
  {"Museums (children’s)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 40.0},
    {"Combined Outdoor Air Rate (cfm/person)", 11.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.3},
    {"Air Class", 1}
  } },
  {"Museums/galleries", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 40.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.6},
    {"Air Class", 1}
  } },
  {"Dwelling unit", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "F,G,H,F"},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 1}
  } },
  {"Common corridors", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", null},
    {"Rp (L/s·person)", null},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 1}
  } },
  {"Sales (except as below)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 15.0},
    {"Combined Outdoor Air Rate (cfm/person)", 16.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.8},
    {"Air Class", 2}
  } },
  {"Mall common areas", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 40.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.6},
    {"Air Class", 1}
  } },
  {"Barbershop", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 10.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.0},
    {"Air Class", 2}
  } },
  {"Beauty and nail salons", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 20.0},
    {"Rp (L/s·person)", 10.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 25.0},
    {"Combined Outdoor Air Rate (cfm/person)", 25.0},
    {"Combined Outdoor Air Rate (L/s·person)", 12.4},
    {"Air Class", 2}
  } },
  {"Pet shops (animal areas)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 26.0},
    {"Combined Outdoor Air Rate (L/s·person)", 12.8},
    {"Air Class", 2}
  } },
  {"Supermarket", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 8.0},
    {"Combined Outdoor Air Rate (cfm/person)", 15.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.6},
    {"Air Class", 1}
  } },
  {"Coin-operated laundries", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 14.0},
    {"Combined Outdoor Air Rate (L/s·person)", 7.0},
    {"Air Class", 2}
  } },
  {"Gym, sports arena (play area)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 20.0},
    {"Rp (L/s·person)", 10.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", "E"},
    {"Default Occupant Density (#/1000 ft²)", 7.0},
    {"Combined Outdoor Air Rate (cfm/person)", 45.0},
    {"Combined Outdoor Air Rate (L/s·person)", 23.0},
    {"Air Class", 2}
  } },
  {"Spectator areas", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 150.0},
    {"Combined Outdoor Air Rate (cfm/person)", 8.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.0},
    {"Air Class", 1}
  } },
  {"Swimming (pool & deck)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", null},
    {"Rp (L/s·person)", null},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.48},
    {"Ra (L/s·m²)", 2.4},
    {"Notes", "C"},
    {"Default Occupant Density (#/1000 ft²)", null},
    {"Combined Outdoor Air Rate (cfm/person)", null},
    {"Combined Outdoor Air Rate (L/s·person)", null},
    {"Air Class", 2}
  } },
  {"Disco/dance floors", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 20.0},
    {"Rp (L/s·person)", 10.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "H"},
    {"Default Occupant Density (#/1000 ft²)", 100.0},
    {"Combined Outdoor Air Rate (cfm/person)", 21.0},
    {"Combined Outdoor Air Rate (L/s·person)", 10.3},
    {"Air Class", 2}
  } },
  {"Health club/aerobics room", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 20.0},
    {"Rp (L/s·person)", 10.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 40.0},
    {"Combined Outdoor Air Rate (cfm/person)", 22.0},
    {"Combined Outdoor Air Rate (L/s·person)", 10.8},
    {"Air Class", 2}
  } },
  {"Health club/weight rooms", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 10.0},
    {"Combined Outdoor Air Rate (cfm/person)", 26.0},
    {"Combined Outdoor Air Rate (L/s·person)", 13.0},
    {"Air Class", 2}
  } },
  {"Bowling alley (seating)", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 5.0},
    {"Rp (L/s·person)", 2.5},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.12},
    {"Ra (L/s·m²)", 0.6},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 40.0},
    {"Combined Outdoor Air Rate (cfm/person)", 13.0},
    {"Combined Outdoor Air Rate (L/s·person)", 6.5},
    {"Air Class", 1}
  } },
  {"Gambling casinos", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 120.0},
    {"Combined Outdoor Air Rate (cfm/person)", 9.0},
    {"Combined Outdoor Air Rate (L/s·person)", 4.6},
    {"Air Class", 1}
  } },
  {"Game arcades", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 7.5},
    {"Rp (L/s·person)", 3.8},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.18},
    {"Ra (L/s·m²)", 0.9},
    {"Notes", null},
    {"Default Occupant Density (#/1000 ft²)", 20.0},
    {"Combined Outdoor Air Rate (cfm/person)", 17.0},
    {"Combined Outdoor Air Rate (L/s·person)", 8.3},
    {"Air Class", 1}
  } },
  {"Stages, studios", new Dictionary<string, object> {
    {"People Outdoor Air Rate Rp (cfm/person)", 10.0},
    {"Rp (L/s·person)", 5.0},
    {"Area Outdoor Air Rate Ra (cfm/ft²)", 0.06},
    {"Ra (L/s·m²)", 0.3},
    {"Notes", "D,H"},
    {"Default Occupant Density (#/1000 ft²)", 70.0},
    {"Combined Outdoor Air Rate (cfm/person)", 11.0},
    {"Combined Outdoor Air Rate (L/s·person)", 5.4},
    {"Air Class", 1}
  } },
};

        // ASHRAE 170 Table 7.1 Healthcare Ventilation Parameters
        public static Dictionary<string, Dictionary<string, object>> ASHRAE170SpaceDesignParams = new Dictionary<string, Dictionary<string, object>> {
  {"Critical and intensive care", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "30-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Delivery room (Cesarean)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 20.0},
    {"Minimum Outdoor ACH", 4},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "68-75/20-24"}
  } },
  {"Emergency department decontamination", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "NR"}
  } },
  {"Emergency department exam/treatment room (p)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes (q)"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Emergency department public waiting area", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Intermediate care (s)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 1.5},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laser eye room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 8.0},
    {"Minimum Outdoor ACH", 3},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "30-60"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Medical/anesthesia gas storage (r)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "68-75/20-24"}
  } },
  {"Newborn intensive care", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 20.0},
    {"Minimum Outdoor ACH", 4},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Operating room (m), (o)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 20.0},
    {"Minimum Outdoor ACH", 4},
    {"All Air Exhausted", "Yes (q), (w)"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Operating surgical cystoscopic rooms (m), (o)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 15.0},
    {"Minimum Outdoor ACH", 3},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Procedure room (o), (d)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Radiology waiting rooms", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Recovery room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 15.0},
    {"Minimum Outdoor ACH", 3},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Substerile service area", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes (q)"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Trauma room (p)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes (q)"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "40-60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Treatment room (p)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Triage", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Wound intensive care (burn unit)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Continued care nursery", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "30-60"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Labor/delivery/recovery (LDR) (s)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Labor/delivery/recovery/postpartum (LDRP) (s)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Newborn nursery suite", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "30-60"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Nourishment area or room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Patient corridor", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Patient room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"PE anteroom (t)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "(e)"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "NR"}
  } },
  {"Protective environment room (t)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "NR"}
  } },
  {"Bathing room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Occupational therapy", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Physical therapy", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Resident sleeping/activity/dining", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Resident room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Resident unit corridor", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Darkroom", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"X-ray (diagnostic and treatment)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"X-ray (surgical/care and catheterization)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 15.0},
    {"Minimum Outdoor ACH", 3},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Autopsy room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "Yes"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "68-75/20-24"}
  } },
  {"Bronchoscopy/sputum collection, and pentamidine administration", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 12.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "Yes"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "68-73/20-23"}
  } },
  {"Dialysis treatment area", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Dialyzer processing room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"ECT procedure room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Endoscope cleaning", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Gastrointestinal endoscopy procedure room (x)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"General examination room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Hydrotherapy", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, bacteriology (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, biochemistry (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, cytology (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, general (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, glasswashing (f)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, histology (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, microbiology (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, nuclear medicine (f)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, pathology (f), (v)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, serology (f)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Laboratory work area, sterilizing (f)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Nonrefrigerated body-holding room (d)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "68-75/20-24"}
  } },
  {"Nuclear medicine hot lab", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "20-60"},
    {"Design Temperature (°F/°C)", "68-73/20-23"}
  } },
  {"Nuclear medicine treatment room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Pharmacy (b)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "NR"}
  } },
  {"Physical therapy", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "72-80/22-27"}
  } },
  {"Special examination room (aa)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Treatment room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "NR"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "NR"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Sterilizer equipment room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "NR"}
  } },
  {"Clean workroom or clean holding", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "68-73/20-23"}
  } },
  {"Decontamination room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 6.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "60-81/16-23"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Sterile storage room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Bathroom", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Bedpan room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Clean linen storage", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Dietary storage", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 2.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "NR"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Food preparation center (t)", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Janitor’s closet", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Laundry, general", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Linen and trash chute room", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Soiled linen sorting and storage", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Warewashing", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "72-78/22-26"}
  } },
  {"Clean workroom or clean holding", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Positive"},
    {"Minimum Total ACH", 4.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "Max 60"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Hazardous material storage", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
  {"Soiled workroom or soiled holding", new Dictionary<string, object> {
    {"Pressure Relationship to Adjacent Areas", "Negative"},
    {"Minimum Total ACH", 10.0},
    {"Minimum Outdoor ACH", 2},
    {"All Air Exhausted", "Yes"},
    {"Air Recirculated by Means of Room Unit", "No"},
    {"Design Relative Humidity (%)", "NR"},
    {"Design Temperature (°F/°C)", "70-75/21-24"}
  } },
};

        // Plug Load Defaults (W/ft²) from ASHRAE and DOE Sources
        public static Dictionary<string, double> PlugLoads_W_per_ft2 = new Dictionary<string, double>
{
    { "62IMC_Office Small", 0.75 },
    { "62IMC_Office Medium", 0.85 },
    { "62IMC_Office Large", 1.0 },
    { "62IMC_Conference Room", 0.5 },
    { "62IMC_Classroom", 0.75 },
    { "62IMC_Lecture Hall", 0.6 },
    { "62IMC_Circulation", 0.2 },
    { "62IMC_Storage Room", 0.2 },
    { "62IMC_Mechanical Room", 1.5 },
    { "62IMC_Break Room", 0.5 },
    { "62IMC_Kitchen", 4.0 },
    { "62IMC_Dining Area", 1.2 },
    { "62IMC_Retail Floor", 1.2 },
    { "62IMC_Gymnasium", 0.6 },
    { "170_Operating Room", 0.5 },
    { "170_Exam Room", 0.5 },
    { "170_Patient Room", 0.4 },
    { "170_Nurse Station", 0.3 },
    { "170_Laboratory", 2.5 },
    { "62IMC_Locker Room", 0.3 }
};

        // ASHRAE 62.1 Exhaust rates
        public static Dictionary<string, Dictionary<string, string>> ASHRAE621ExhaustRates = new Dictionary<string, Dictionary<string, string>>
        {
            ["62IMC_Arena"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Art Classroom"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.70" } },
            ["62IMC_Auto Repair Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.50" } },
            ["62IMC_Barber Shop"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Beauty Salon"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.60" } },
            ["62IMC_Cell with Toilet"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.00" } },
            ["62IMC_Copy Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Darkroom"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.00" } },
            ["62IMC_Science Lab"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.00" } },
            ["62IMC_Janitor Closet"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.00" } },
            ["62IMC_Kitchenette"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.30" } },
            ["62IMC_Commercial Kitchen"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.70" } },
            ["62IMC_Locker Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Locker Room Other"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.25" } },
            ["62IMC_Shower Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Parking Garage"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.75" } },
            ["62IMC_Pet Shop"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.90" } },
            ["62IMC_Soiled Laundry Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.00" } },
            ["62IMC_Storage Room"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "1.50" } },
            ["62IMC_Toilet Private"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } },
            ["62IMC_Toilet Public"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.70" } },
            ["62IMC_Woodwork Classroom"] = new Dictionary<string, string> { { "Exhaust Rate (cfm/ft²)", "0.50" } }
        };
    }
}