using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalApp.Models
{
    public partial class Properties
    {
        public Properties()
        {
            Buildings = new HashSet<Buildings>();
            Events = new HashSet<Events>();
        }

        public int PropertyId { get; set; }
        public int? ManagerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual Users Manager { get; set; }
        public virtual ICollection<Buildings> Buildings { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}
