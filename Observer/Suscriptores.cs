using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Suscriptores
    {
        public string nom { get; set; }
        public string ape { get; set; }

        public Suscriptores(string nom, string ape)
        {
            this.nom = nom;
            this.ape = ape;
        }

        public void Update()
        {
            Console.WriteLine($"{nom} {ape} RECIBI LA NOTIFICACION");
        }
    }
}
