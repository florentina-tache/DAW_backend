using System;
using System.Collections.Generic;
using DAW_Store.Models.Base;

namespace DAW_Store.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }

        public float Image { get; set; }

        public float Currency { get; set; }

        public float Price { get; set; }
        public string Quantity { get; set; }

        public ICollection<OrderProductRelation> OrderProductRelations { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; } // foreign key
    }
}