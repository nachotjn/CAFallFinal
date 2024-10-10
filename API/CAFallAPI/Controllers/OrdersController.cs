using CAFallAPI;
using global::Microsoft.AspNetCore.Mvc;
using global::CAFallAPI.Models;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::Microsoft.EntityFrameworkCore;
using global.CAFallAPI.Models;
using global.CAFallAPI.Models;

namespace global::CAFallAPI.Controllers
{
    [global::Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [global::Microsoft.AspNetCore.Mvc.ApiController]
    public class OrderController : global::Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [global::Microsoft.AspNetCore.Mvc.HttpPost]
        public global::Microsoft.AspNetCore.Mvc.ActionResult<Order> CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }

        [global::Microsoft.AspNetCore.Mvc.HttpGet]
        public global::Microsoft.AspNetCore.Mvc.ActionResult<global::System.Collections.Generic.IEnumerable<Order>> GetOrders()
        {
            return _context.Orders.Include(o => o.OrderItems).ToList();
        }

        public async global::System.Threading.Tasks.Task<object> PlaceOrder(Order order)
        {
            throw new global::System.NotImplementedException();
        }

        public async global::System.Threading.Tasks.Task<object> GetOrderHistory()
        {
            throw new global::System.NotImplementedException();
        }
    }
}