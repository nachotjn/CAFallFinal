using Microsoft.AspNetCore.Mvc;
using CAFallAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CAFallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Order> CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return _context.Orders.Include(o => o.OrderItems).ToList();
        }

        public async Task<object> PlaceOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<object> GetOrderHistory()
        {
            throw new System.NotImplementedException();
        }
    }
}