using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptador {
    internal class Adaptador {
        public static string XMLtoJSON(string xml) {
            if (xml == "es XML")
            {
                return "es JSON";
            }
            else
            {
                return "";
            }
        }
        public static string WordtoExcel(string word)
        {
            if (word == "es DOCX")
            {
                return "es XLSX";
            }
            else
            {
                return "";
            }
        }
    }
}
