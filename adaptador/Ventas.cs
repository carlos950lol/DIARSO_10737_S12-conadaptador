using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptador
{
    internal class ventas
    {
        public static void RecibeXLSX(string mensaje)
        {
            switch (mensaje)
            {
                case "es XLSX": { Console.WriteLine("OK ES XLSX"); break; }
                default: { Console.WriteLine("ERROR"); break; };
            }
        }
    }
}
