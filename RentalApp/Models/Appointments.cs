using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalApp.Models
{
    public partial class Appointments
    {
        public int AppointmentId { get; set; }
        public int? TenantId { get; set; }
        public int? PropertyManagerId { get; set; }
        public int? ApartmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        public virtual Apartments Apartment { get; set; }
        public virtual Users PropertyManager { get; set; }
        public virtual Users Tenant { get; set; }
    }
}
