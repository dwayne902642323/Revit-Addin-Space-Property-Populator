# 🏗️ SpacePopulator – Revit Add-In for Standards-Compliant Space Parameter Automation
## 🔧 What Is It?

**SpacePopulator** is a C# Revit API add-in that automatically populates space-level parameters in a Revit model based on official engineering standards. Designed for MEP engineers and BIM professionals, this tool injects validated design-intent data — airflow rates, internal loads, temperature, humidity, and more — into every selected `Space` object using structured logic from:

- **ASHRAE 62.1** (Ventilation for Acceptable IAQ)
- **ASHRAE 170** (Healthcare Ventilation)
- **ASHRAE 90.1** (Lighting Power Density)
- **IMC Table 403.3.1.1**
- **ASHRAE Fundamentals**

---

## ✨ Key Features

- 🔍 **Auto-classifies Revit Spaces** using name-based logic (healthcare, commercial, or unclassified)
- 📚 **Loads data from central C# dictionaries** of ASHRAE & IMC values
- 🧠 **Populates critical design parameters**:
  - Supply / Return / Exhaust Airflow (cfm)
  - Outdoor Air per Person & Area (Rp, Ra)
  - Total and Minimum ACH
  - Lighting Load (W/ft²), Plug Load (W/ft²)
  - People Sensible/Latent Gains (Btu/h)
  - Design Temperature and RH Setpoints
  - Pressure relationship tags (e.g., positive/negative)
- 📤 **Supports gbXML export** for use in Trane Trace, EnergyPlus, OpenStudio
- 🛠️ **Code-driven compliance** with ASHRAE and IMC ventilation rates
- 💡 **Fully modular architecture** using separate `.cs` files for classification, parameter writing, dictionary loading, and app registration
- 🧪 **Validates data safely** using overwrite logic, null handling, and storage-type checks
- ✅ **Engineer-focused**: Designed to match mechanical workflows and QA standards

---

## 🧩 Architecture

- `App.cs` — Registers ribbon UI and app lifecycle
- `WriteSpaceParameters.cs` — Main external command
- `SpaceClassifier.cs` — Pattern-matching logic to assign each space to a standard cluster
- `SpaceOverrideEngine.cs` — Core parameter population logic and unit conversions
- `ASHRAE_Dictionaries.cs` — Code-driven dictionary of all HVAC parameters, compliant with multiple ASHRAE standards
- `SpacePopulator.sln` — Visual Studio solution file

---

## 🖥️ Getting Started

### ✅ Prerequisites
- Autodesk Revit 2023 or newer
- Visual Studio 2022
- .NET Framework 4.8
- Basic understanding of Revit shared parameters and BIM space elements

### 🛠️ Installation
1. Clone or download this repo
2. Build the solution in Visual Studio (Release mode)
3. Copy `SpacePopulator.dll` to your Revit `Addins\20XX` folder
4. Add the provided `.addin` XML manifest file
5. Launch Revit → Select spaces → Click the “Write Space Params” button

---

## 🧪 Sample Output

Each Revit space will be updated with:

- `Design Supply Airflow` → Automatically calculated from heat gain or ACH (whichever is greater)
- `Design Exhaust Airflow` → Set per IMC or ASHRAE 170
- `Lighting Load` → Based on ASHRAE 90.1 LPD and space area
- `Plug Load Density` → Based on space type
- `People Sensible Gain` → From Fundamentals human activity profiles
- `ASHRAE_SpaceTypeID` → For traceability, e.g., `170_Operating Room`

---

## 🧠 Use Cases

- Healthcare space compliance with ASHRAE 170
- Early-phase energy modeling for LEED/90.1 Appendix G
- gbXML-ready data for Trane Trace, EnergyPlus, IES-VE
- Input automation for mechanical load calcs and controls mapping

---

## 📚 References

- ASHRAE 62.1-2022
- ASHRAE 170-2021
- ASHRAE 90.1-2019
- ASHRAE Fundamentals 2021 Handbook
- IMC 2021 Table 403.3.1.1

---

## 📄 License

Use freely with attribution. No official affiliation with ASHRAE or Autodesk.

---

## 🤝 Connect

If this add-in saved you time or inspired a new workflow, feel free to connect:

**Derek Eubanks, PE, HFDP, CHD, HBDP**
- 🧠 MSCS Candidate, Georgia Tech (Machine Learning)
- 🔗 [LinkedIn]([https://www.linkedin.com/in/yourprofile](https://www.linkedin.com/in/derek-w-46120b74/))
- 💻 [GitHub](https://github.com/dwayne902642323)

---

## 🚀 Next Features (Planned)

- Spatial adjacency logic for pressure relationship enforcement
- Interactive override UI for engineer-reviewed edits
- Automatic air balancing between spaces (transfer air logic)
- Carbon-aware parameters per ASHRAE 228

---

> This project embodies a vision: making Revit a true engineering tool — not just a modeling platform — through programmable, standards-driven automation.
