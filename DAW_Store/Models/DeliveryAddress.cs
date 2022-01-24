using System;
using DAW_Store.Models.Base;
namespace DAW_Store.Models

{
    public class DeliveryAddress : BaseEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZIPCode { get; set; }

        public Order Order { get; set; }
        public Guid OrderId { get; set; }
    }
}