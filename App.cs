using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using System.Reflection;

namespace ASHRAE.SpaceOverrides
{
    public class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            // Tab and panel names
            string tabName = "Custom HVAC Tools";
            string panelName = "Space Parameters";

            try
            {
                application.CreateRibbonTab(tabName);
            }
            catch { /* Tab already exists */ }

            RibbonPanel panel = application.CreateRibbonPanel(tabName, panelName);

            // Path to this assembly
            string assemblyPath = Assembly.GetExecutingAssembly().Location;

            // Create push button to run the command
            PushButtonData buttonData = new PushButtonData(
                "WriteSpaceParams",
                "Write\nSpace Params",
                assemblyPath,
                "ASHRAE.SpaceOverrides.WriteSpaceParameters"
            );

            // Add button to panel
            panel.AddItem(buttonData);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
