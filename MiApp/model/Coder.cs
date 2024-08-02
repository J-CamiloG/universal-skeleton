using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skeleton.MiApp.model
{
    public class Coder : Persona
    {
        public string Clan { get; set; }

        public Coder(string nombre, string apellido, string numeroDocumento, string email, string telefono, string clan)
            : base(nombre, apellido,numeroDocumento, email, telefono)
        {
            Clan = clan;
        }

        public static Coder PedirInformacion()
        {
            Console.WriteLine("Ingrese el nombre del Coder: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del Coder: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de documento del Coder: ");
            string numeroDocumento = Console.ReadLine();
            Console.WriteLine("Ingrese el email del Coder: ");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del Coder: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el clan del Coder: ");
            string clan = Console.ReadLine();
            
            var nuevoIngreso = new Coder(nombre, apellido, numeroDocumento, email, telefono, clan);

            return nuevoIngreso;
        }

        public override void MostrarInformacion()
        {   
            base.MostrarInformacion();
            Console.WriteLine($"| Clan: {Clan}");
        }
    }
}