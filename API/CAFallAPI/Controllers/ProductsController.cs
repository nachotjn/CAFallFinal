using CAFallAPI;
using global::Microsoft.AspNetCore.Mvc;
using global::CAFallAPI.Models;
using global::System.Collections.Generic;
using global::System.Linq;

namespace global::CAFallAPI.Controllers
{
    [global::Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [global::Microsoft.AspNetCore.Mvc.ApiController]
    public class ProductController : global::Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [global::Microsoft.AspNetCore.Mvc.HttpGet]
        public global::Microsoft.AspNetCore.Mvc.ActionResult<global::System.Collections.Generic.IEnumerable<global::CAFallAPI.Models.Product>> GetProducts(string searchTerm)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm));
            }

            return products.ToList();
        }

        [global::Microsoft.AspNetCore.Mvc.HttpPost]
        public global::Microsoft.AspNetCore.Mvc.ActionResult<global::CAFallAPI.Models.Product> CreateProduct(global::CAFallAPI.Models.Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}