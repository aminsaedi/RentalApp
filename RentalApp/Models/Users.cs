using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentalApp.Models;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalApp.Models
{
    public partial class Users
    {
        public Users()
        {
            AppointmentsPropertyManager = new HashSet<Appointments>();
            AppointmentsTenant = new HashSet<Appointments>();
            MessagesReceiver = new HashSet<Messages>();
            MessagesSender = new HashSet<Messages>();
            Properties = new HashSet<Properties>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Appointments> AppointmentsPropertyManager { get; set; }
        public virtual ICollection<Appointments> AppointmentsTenant { get; set; }
        public virtual ICollection<Messages> MessagesReceiver { get; set; }
        public virtual ICollection<Messages> MessagesSender { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
    }
}
