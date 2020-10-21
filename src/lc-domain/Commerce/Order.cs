using System.Collections.Generic;
using Common;

namespace Domain
{
    public class Order : Entity<int>
    {
        public string OrderNumber { get; set; } 
        public string CartId { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public Address ShippingAddress { get; set; }
        public Payment Payment { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}