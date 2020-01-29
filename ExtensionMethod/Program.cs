using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product { Id = 1, ProductName = "Mobile Phone", Price = 10000 },
                new Product { Id = 2, ProductName = "Headphone", Price = 550 },
                new Product { Id = 3, ProductName = "Bluetooth", Price = 600 }
            };

            foreach (var item in product)
            {
                Console.WriteLine("Product Name:{0} \t Price:{1}", item.ProductName,item.Price);
            }

            Console.WriteLine("\n-----Product With VAT-----");
            foreach (var item in product)
            {
                Console.WriteLine("Product Name:{0} Price:{1} VAT:{2}", item.ProductName, item.Price, item.CalculateVat());
            }
            Console.ReadLine();
        }
    }
}
