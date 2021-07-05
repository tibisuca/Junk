using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class Car
    {
        public Car()
        {
            InverseBlockedByNavigation = new HashSet<Car>();
            InverseBlockingNavigation = new HashSet<Car>();
        }

        public string LicensePlate { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Guid OwnerId { get; set; }
        public string Blocking { get; set; }
        public string BlockedBy { get; set; }
        public decimal LocationLat { get; set; }
        public decimal LocationLong { get; set; }
        public byte[] CarImage { get; set; }

        public virtual Car BlockedByNavigation { get; set; }
        public virtual Car BlockingNavigation { get; set; }
        public virtual ICollection<Car> InverseBlockedByNavigation { get; set; }
        public virtual ICollection<Car> InverseBlockingNavigation { get; set; }
    }
}
