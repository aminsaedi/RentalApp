using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalApp.Models
{
    public partial class Apartments
    {
        public Apartments()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int ApartmentId { get; set; }
        public int? BuildingId { get; set; }
        public string Name { get; set; }
        public int? Floor { get; set; }
        public int? Bedrooms { get; set; }

        public virtual Buildings Building { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
