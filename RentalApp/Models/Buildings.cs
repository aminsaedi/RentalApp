using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalApp.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            Apartments = new HashSet<Apartments>();
        }

        public int BuildingId { get; set; }
        public int? PropertyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual Properties Property { get; set; }
        public virtual ICollection<Apartments> Apartments { get; set; }
    }
}
