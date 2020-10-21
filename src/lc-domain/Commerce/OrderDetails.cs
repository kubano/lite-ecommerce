using Common;

namespace Domain
{
    public class OrderDetails : Entity<int>
    {

        public string CartId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}