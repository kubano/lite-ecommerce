using Common;

namespace Domain
{
    public class Payment : Entity<int>
    {
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public Address BillingAddress { get; set; }
        public Order Order { get; set; }
    }
}