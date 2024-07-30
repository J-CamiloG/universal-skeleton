using System;
using MiApp.Model;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            var product1 = new Product { Id = 1, Name = "Laptop", Price = 1000m };
            var product2 = new Product { Id = 2, Name = "Smartphone", Price = 500m };

            productRepository.Create(product1);
            productRepository.Create(product2);

            var readProduct = productRepository.Read(1);
            Console.WriteLine($"Producto leído: {readProduct.Name}, Precio: {readProduct.Price}");

            product1.Name = "Gaming Laptop";
            product1.Price = 1500m;
            productRepository.Update(product1);

            readProduct = productRepository.Read(1);
            Console.WriteLine($"Producto actualizado: {readProduct.Name}, Precio: {readProduct.Price}");

            productRepository.Delete(2);

            var deletedProduct = productRepository.Read(2);
            if (deletedProduct == null)
            {
                Console.WriteLine("Producto con ID 2 eliminado.");
            }

            Console.ReadLine();
        }
    }
}
