#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace helloWorld
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("appStartup", "Application is Starting Up");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("appShutdown", "Application is Shutting Down");
            return Result.Succeeded;
        }
    }
}
