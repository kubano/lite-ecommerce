using Common;

namespace  Domain
{
    public class Phone : Entity<int>
    {
        public string Number { get; set; } 
        public string PhoneType { get; set; } 
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}