using System.Collections.Generic;
using DAW_Store.Models.Base;

namespace DAW_Store.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}