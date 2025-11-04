using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Proxy
    {
        public static void LOG(string nombre, string apellido) {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
        }

        public static void TipoCambio(double sol)
        { 
            Console.WriteLine($"Y convierte {sol} soles a {Sunat.tipoCambio(sol)} dolares"); 
        }
    }
}
