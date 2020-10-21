using Common;

namespace Domain
{
    public class Address : Entity<int>
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode4 { get; set; }
        public string ZipCode5 { get; set; }

        public string StateCode { get; set; }

        public string AddressType {get; set;}

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}