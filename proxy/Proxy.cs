using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Proxy
    {
        Sunat sunat=new Sunat();


        public static void TipoCambio(double sol, string nombre, string apellido)
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Y convierte {sol} soles a {Sunat.tipoCambio(sol)} dolares"); 
        }
    }
}
