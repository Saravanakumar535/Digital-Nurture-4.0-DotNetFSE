using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RetailInventorySystem.Data;

var builder = WebApplication.CreateBuilder(args);

// Register AppDbContext with connection string from appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Lab 2: Database Context Configured ");

app.Run();
