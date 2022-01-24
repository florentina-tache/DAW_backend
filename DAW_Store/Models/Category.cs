using System.Collections.Generic;
using DAW_Store.Models.Base;

namespace DAW_Store.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Item> Products { get; set; }
    }
}