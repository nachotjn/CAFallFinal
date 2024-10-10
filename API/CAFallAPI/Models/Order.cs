using System;
using System.Collections.Generic;

namespace CAFallAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public List<OrderEntry> OrderEntries { get; set; }
    }

    public class OrderEntry
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}