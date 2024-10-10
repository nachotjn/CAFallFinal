using global::Microsoft.EntityFrameworkCore;
using global::CAFallAPI.Models;

namespace CAFallAPI
{
    public class AppDbContext : global::Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(global::Microsoft.EntityFrameworkCore.DbContextOptions<global::CAFallAPI.AppDbContext> options) : base(options) { }

        public global::Microsoft.EntityFrameworkCore.DbSet<global::CAFallAPI.Models.Product> Products { get; set; }
        public global::Microsoft.EntityFrameworkCore.DbSet<global::CAFallAPI.Models.Order> Orders { get; set; }
    }
}