using System;
using Microsoft.EntityFrameworkCore;
using RetailInventorySystem.Data;

namespace RetailInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailDB;Trusted_Connection=True;");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                // Optional: Apply migrations automatically
                context.Database.Migrate();

                Console.WriteLine("Database connected and ready!");
            }
        }
    }
}
