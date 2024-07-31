using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using skeleton.interfaceCrud;

namespace skeleton.MiApp.model
{
    public class CoderSystem : Coder, ICrudSystem
    {
        private readonly List<Coder> _coders;
        public CoderSystem()
        {
            _coders = new List<Coder>
            {
                new Coder { Id = 1, Nombre = "Juan", Apellido = "Pérez", Email = "juan.perez@example.com", Telefono = "123456789" },
                new Coder { Id = 2, Nombre = "Ana", Apellido = "García", Email = "ana.garcia@example.com", Telefono = "987654321" },
                new Coder { Id = 3, Nombre = "Luis", Apellido = "Martínez", Email = "luis.martinez@example.com", Telefono = "555555555" }
            };
        }
        public void Create()
        {
            var nuevoCoder = new Coder();

            Console.WriteLine("Ingrese su nombre: ");
            nuevoCoder.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            nuevoCoder.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su email: ");
            nuevoCoder.Email = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            nuevoCoder.Telefono = Console.ReadLine();

            nuevoCoder.Id = _coders.Count > 0 ? _coders.Max(c => c.Id) + 1 : 1;
            _coders.Add(nuevoCoder);
            Console.WriteLine("Coder agregado exitosamente.");
        }
        public void Read()
        {
            foreach (var i in _coders )
            {
                Console.WriteLine($"{i.Nombre}");
            }
        }
        public void Update()
        {
            Console.WriteLine("Ingrese el Nombre del Coder a actualizar:");
            string? nombreBuscado = Console.ReadLine();
            var codersToUpdate = _coders.Where(c => c.Nombre == nombreBuscado).ToList();

            if (codersToUpdate.Any())
            {
                foreach (var coder in codersToUpdate)
                {
                    Console.WriteLine($"Actualizando Coder con ID: {coder.Id}");

                    Console.WriteLine("¿Qué dato desea actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Email");
                    Console.WriteLine("4. Teléfono");
                    Console.WriteLine("5. Todos los datos");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            coder.Nombre = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            coder.Apellido = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nuevo email:");
                            coder.Email = Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine("Ingrese el nuevo teléfono:");
                            coder.Telefono = Console.ReadLine();
                            break;
                        case "5":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            coder.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            coder.Apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo email:");
                            coder.Email = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo teléfono:");
                            coder.Telefono = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                Console.WriteLine($"{codersToUpdate.Count} Coder(s) actualizado(s) exitosamente.");
            }
            else
            {
                Console.WriteLine("Coder no encontrado.");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Ingrese el Nombre del Coder a Eliminar:");
            string? nombreBuscado = Console.ReadLine();
            var codersToUpdate = _coders.Where(c => c.Nombre == nombreBuscado).ToList();

            if (codersToUpdate.Any())
            {
                Console.WriteLine("¿Desea eliminar el Coder? (S/N)");
                string? respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "S")
                {
                    _coders.Remove(codersToUpdate.First());
                }
            }
        }

    }
}