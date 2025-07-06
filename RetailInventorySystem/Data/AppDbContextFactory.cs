using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RetailInventorySystem.Data;

namespace RetailInventorySystem.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseSqlServer(
    "Server=LAPTOP-TDOC74DH\\SQLEXPRESS;Database=RetailDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
