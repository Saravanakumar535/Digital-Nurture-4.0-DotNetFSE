using Microsoft.EntityFrameworkCore;
using RetailInventorySystem.Models;

namespace RetailInventorySystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Optional: Seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Mouse", Quantity = 20 },
                new Product { ProductId = 2, ProductName = "Keyboard", Quantity = 10 }
            );
        }
    }
}
