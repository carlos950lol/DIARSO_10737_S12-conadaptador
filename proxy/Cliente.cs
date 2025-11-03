using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    public class Cliente
    {
        public static void ConversionDolar(double sol,string nombre,string apellido)
        {
            Proxy.TipoCambio(sol,nombre,apellido);
        }    
    }
}
