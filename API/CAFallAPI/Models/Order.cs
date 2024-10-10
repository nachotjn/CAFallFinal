using global::System;
using global::System.Collections.Generic;
using OrderEntry = global.CAFallAPI.Models.OrderEntry;
using OrderItem = global.CAFallAPI.Models.OrderItem;

namespace global::CAFallAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public global::System.DateTime OrderDate { get; set; }
        public global::System.Collections.Generic.List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public global::System.Collections.Generic.List<OrderEntry> OrderEntries { get; set; }
    }

    public class OrderEntry
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}