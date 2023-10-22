using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ASPNetWebAppMvcPRMWebsite.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Tenant
    {
        [Key]
        public int T_Id { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "Tenant ID")]
        public int TenantId { get; set; }
        
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        
        [StringLength(20)]
        public string Password { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<ScheduleAppointment> ScheduleAppointments { get; set; }
    }
}