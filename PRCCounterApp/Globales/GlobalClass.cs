using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRCCounterApp.Globales
{
    public class ProgramAttributes
    {
        public string TempPath = string.Empty;
        public string AppPath = string.Empty;
        public string AppName = string.Empty;
        public string AppVersion = string.Empty;
        public void Init(Assembly _assbly)
        {
            Assembly assbly = _assbly;
            AppPath = Path.GetDirectoryName(assbly.Location);
            TempPath = Path.GetTempPath();
            AppName = assbly.GetName().ToString().Split(',')[0];
            AppVersion = assbly.GetName().Version.ToString();
        }


    }

    public static class StaticAppFunctions
    {
        public static ProgramAttributes GetProgrammAttributes(Assembly ass)
        {
            ProgramAttributes pa = new ProgramAttributes();
            pa.Init(ass);
            return pa;
        }
    }
}
