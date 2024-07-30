using System;
using System.Collections.Generic;

namespace MiApp.Model
{
    public class ProductRepository : CrudRepository<Product>
    {
        private readonly List<Product> _products = new List<Product>();

        public override void Create(Product entity)
        {
            _products.Add(entity);
            Console.WriteLine($"Producto {entity.Name} creado.");
        }

        public override Product Read(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public override void Update(Product entity)
        {
            var product = Read(entity.Id);
            if (product != null)
            {
                product.Name = entity.Name;
                product.Price = entity.Price;
                Console.WriteLine($"Producto {entity.Name} actualizado.");
            }
        }

        public override void Delete(int id)
        {
            var product = Read(id);
            if (product != null)
            {
                _products.Remove(product);
                Console.WriteLine($"Producto con ID {id} eliminado.");
            }
        }
    }
}
