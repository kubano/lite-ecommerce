using Common;

namespace Domain
{
    public class EmailAddress : Entity<int>
    {
        public int PersonId { get; set; }
        public string Email { get; set; }

        public string ContactItemStatus {get; set;}
 

        public Person Person { get; set; }
    }
}