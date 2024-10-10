using global::System.Collections.Generic;
using Order = global.CAFallAPI.Models.Order;

namespace global::CAFallAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public global::System.Collections.Generic.List<Order> Orders { get; set; } = new global::System.Collections.Generic.List<Order>();
    }
}