using CAFallAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CAFallAPI.Tests;

public static class TestDbContextFactory
{
    public static AppDbContext CreateInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDatabase") 
            .Options;

        var context = new AppDbContext(options);

        SeedData(context);

        return context;
    }

    private static void SeedData(AppDbContext context)
    {
        context.Products.Add(new Product { Id = 1, Name = "Sample Product", Stock = 10 });
        context.SaveChanges();
    }
}