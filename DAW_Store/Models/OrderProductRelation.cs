using System;

namespace DAW_Store.Models
{
    public class OrderProductRelation
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Item Product { get; set; }
    }
}