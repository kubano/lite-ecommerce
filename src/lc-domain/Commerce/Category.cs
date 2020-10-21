using System.Collections.Generic;
using Common;

namespace Domain
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
} 