using System;
using System.Linq;

namespace RetailInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 5: Retrieving Data from the Database ");

            using (var context = new RetailDbContext())
            {
                var products = context.Products.ToList();

                Console.WriteLine("Product List:");
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Quantity: {product.Quantity}");
                }
            }
        }
    }
}
