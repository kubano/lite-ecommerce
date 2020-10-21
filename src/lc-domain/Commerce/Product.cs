using System.Collections.Generic;
using Common;

namespace Domain
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte StockInventory { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}