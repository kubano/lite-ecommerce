using System;
using System.Collections.Generic;
using Common;

namespace Domain
{
    public class Person : Entity<int>
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; } 

        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>();
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
        public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
    }
}