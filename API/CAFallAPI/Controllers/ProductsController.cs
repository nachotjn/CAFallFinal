using Microsoft.AspNetCore.Mvc;
using CAFallAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace CAFallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts(string searchTerm)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm));
            }

            return products.ToList();
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}