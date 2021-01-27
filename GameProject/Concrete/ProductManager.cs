using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class ProductManager : IProductManager
    {        
        public void Add(Product product)
        {
            Console.WriteLine($"Product added : { product.Name}");
        }        

        public void Delete(Product product)
        {
            Console.WriteLine($"Product deleted : { product.Name}");
        }        

        public void Update(Product product)
        {
            Console.WriteLine($"Product updated : { product.Name}");
        }        
    }
}
