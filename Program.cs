using System;
using skeleton.MiApp.model;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coderSystem = new CoderSystem();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear un nuevo Coder");
                Console.WriteLine("2. Leer todos los Coders");
                Console.WriteLine("3. Actualizar un Coder");
                Console.WriteLine("4. Eliminar un Coder");
                Console.WriteLine("5. Salir");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        coderSystem.Create();
                        break;
                    case "2":
                        coderSystem.Read();
                        break;
                    case "3":
                        coderSystem.Update();
                        break;
                    case "4":
                        coderSystem.Delete();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }
    }
}
