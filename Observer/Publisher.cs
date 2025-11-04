using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {
        List<Suscriptores> ListaSuscriptores=new List<Suscriptores>();

        public void AgregarSuscriptor(string nom,string ape)
        {
            ListaSuscriptores.Add(new Suscriptores(nom,ape));
        }

        public void NotificarSuscriptores()
        {
            foreach (Suscriptores suscriptor in ListaSuscriptores)
            {
                suscriptor.Update();
            }
        }

        public void VerSuscriptores()
        {
            int i=0;
            foreach (Suscriptores suscriptor in ListaSuscriptores)
            {
                i++;
                Console.WriteLine($"Suscriptor {i}: {suscriptor.nom} {suscriptor.ape}");
            }
        }

    }
}
