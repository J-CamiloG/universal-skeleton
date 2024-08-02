using System;
using System.Collections.Generic;
using System.Linq;
using skeleton.interfaceCrud;

namespace skeleton.MiApp.model
{
    public class CoderSystem : ICrudSystem
    {
        private readonly List<Coder> _coders;

        public CoderSystem()
        {
            _coders = new List<Coder>
            {
                new Coder("Juan", "Perez", "1", "juan.perez@example.com", "123456789", "Dell"),
                new Coder("Juan", "Perez", "2", "juan.perez@example.com", "123456789", "Dell"),
                new Coder("Maria", "Gomez", "3", "maria.gomez@example.com", "987654321", "HP"),
                new Coder("Carlos", "Lopez", "4", "carlos.lopez@example.com", "456123789", "Apple"),
                new Coder("Ana", "Martinez", "56", "ana.martinez@example.com", "321654987", "Microsoft"),
                new Coder("Luis", "Rodriguez", "12", "luis.rodriguez@example.com", "789456123", "IBM"),
                new Coder("Sofia", "Hernandez", "13", "sofia.hernandez@example.com", "147258369", "Google"),
                new Coder("David", "Ramirez", "67", "david.ramirez@example.com", "963852741", "Facebook"),
                new Coder("Laura", "Fernandez", "88", "laura.fernandez@example.com", "741852963", "Amazon"),
                new Coder("Jorge", "Gonzalez", "99", "jorge.gonzalez@example.com", "852963741", "Netflix"),
                new Coder("Marta", "Diaz", "00", "marta.diaz@example.com", "369258147", "Twitter")
            };
        }

        public void Create( object nuevoElemento )
        {
            if (nuevoElemento == null)
            {
                Console.WriteLine("El objeto no puede ser null.");
                return;
            }
            if (nuevoElemento is Coder nuevoEmpleado)
            {
                _coders.Add(nuevoEmpleado);
                Console.WriteLine("Empleado agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Tipo no soportado.");
            }
            
        }

        public void Read()
        {
            foreach (var i in _coders)
            {
                i.MostrarInformacion();
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
                    Console.WriteLine($"Actualizando Coder con ID: {coder.GetId()}");

                    Console.WriteLine("¿Qué dato desea actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Email");
                    Console.WriteLine("4. Teléfono");
                    Console.WriteLine("5. Clan");
                    Console.WriteLine("6. Todos los datos");

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
                            Console.WriteLine("Ingrese el nuevo clan:");
                            coder.Clan = Console.ReadLine();
                            break;
                        case "6":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            coder.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            coder.Apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo email:");
                            coder.Email = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo teléfono:");
                            coder.Telefono = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo clan:");
                            coder.Clan = Console.ReadLine();
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
            Console.WriteLine("Ingrese el Documento del Coder a eliminar:");
            string? documentoBuscado = Console.ReadLine();
            var coderToDelete = _coders.FirstOrDefault(c => c.NumeroDocumento == documentoBuscado);

            if (coderToDelete != null)
            {
                Console.WriteLine("¿Desea eliminar el Coder? (S/N)");
                string? respuesta = Console.ReadLine();
                if (respuesta != null && respuesta.ToUpper() == "S")
                {
                    _coders.Remove(coderToDelete);
                    Console.WriteLine("Coder eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Coder no encontrado.");
            }
        }
    }
}
