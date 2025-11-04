using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer; 

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            publisher.AgregarSuscriptor("Carlos","Conde");
            publisher.AgregarSuscriptor("Fabian", "Montoya");
            publisher.AgregarSuscriptor("Andrea", "Sanchez");
            publisher.AgregarSuscriptor("Juliette", "Casapia");

            int op = 1;
            string nombre;
            string apellido;
            while(op != 5)
            {
               
                    Console.Clear();
                    Console.WriteLine(".      -- INTERFAZ DEL PUBLISHER --");
                    Console.WriteLine("1. Agregar Suscriptor");
                    Console.WriteLine("2. Notificar Suscriptores");
                    Console.WriteLine("3. Ver Suscriptores");
                    Console.WriteLine("5. SALIR");
                    Console.WriteLine("Ingrese una opcion");
                    op=Convert.ToInt16(Console.ReadLine());
                
                switch (op)
                {
                    case 1: {
                            Console.WriteLine("Ingresa el nombre del suscriptor");
                            nombre= Console.ReadLine();
                            Console.WriteLine("Ingresa el apellido del suscriptor");
                            apellido= Console.ReadLine();
                            publisher.AgregarSuscriptor(nombre, apellido);
                            Console.WriteLine("El suscriptor se agrego con exito");
                            break; 
                        }
                    case 2:
                        {
                            publisher.NotificarSuscriptores();
                            break;
                        }
                    case 3:
                        {
                            publisher.VerSuscriptores();
                            break;
                        }
                    case 5: Console.WriteLine("Saliendo Del Sistema");break;
                    default:Console.WriteLine("INGRESE UNA OPCION VALIDA");break;
                }
                if (op!=5)
                {
                    Console.WriteLine("Presione Enter para continuar.");
                    Console.ReadLine();
                }
               
            }
        }
    }
}
