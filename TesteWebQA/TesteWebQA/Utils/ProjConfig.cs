using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebQA.Utils
{
    public static class ProjConfig
    {
        private static string DEFAULT_PATH = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName).Parent.FullName + "\\Reports\\";

        public static String GetPath()
        {
            return DEFAULT_PATH;
        }
    }
}
