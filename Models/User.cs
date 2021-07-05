using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public byte[] ProfilePicture { get; set; }
        public decimal Rating { get; set; }
        public int NoRatings { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public User()
        {
            Cars = new HashSet<Car>();
        }
    }
}
