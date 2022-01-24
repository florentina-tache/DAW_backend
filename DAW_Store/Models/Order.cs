using System;
using System.Collections.Generic;
using DAW_Store .Models.Base;

namespace DAW_Store.Models
{
    public class Order : BaseEntity
    {
        public float TotalPrice { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; } // foreign key

        public DeliveryAddress DeliveryAddress { get; set; }

        public ICollection<OrderProductRelation> OrderProductRelations { get; set; }
    }
}