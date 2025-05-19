using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ASHRAE.SpaceOverrides
{
    [Transaction(TransactionMode.Manual)]  // ← This line is required
    public class WriteSpaceParameters : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            var selection = commandData.Application.ActiveUIDocument.Selection.GetElementIds();

            using (Transaction tx = new Transaction(doc, "Apply ASHRAE Overrides"))
            {
                tx.Start();
                foreach (ElementId id in selection)
                {
                    if (doc.GetElement(id) is Space space)
                    {
                        SpaceOverrideEngine.ApplyStandardOverrides(space, doc);
                    }
                }
                tx.Commit();
            }

            return Result.Succeeded;
        }
    }
}
