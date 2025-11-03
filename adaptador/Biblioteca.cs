using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptador {
    internal class Biblioteca {
        public static void RecibeJSON(string mensaje) {
            switch (mensaje)
            {
                case "es JSON": { Console.WriteLine("OK ES JSON"); break; }

                default: { Console.WriteLine("ERROR");break; };
            }
        }
    }
}
