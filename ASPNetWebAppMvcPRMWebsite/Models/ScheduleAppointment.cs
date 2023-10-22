using ASP.NETCorePRMWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetWebAppMvcPRMWebsite.Models
{
    public class ScheduleAppointment
    {
        [Key]
        public int SA_Id { get; set; }

        [Display(Name = "Schedule Appointment ID")]
        public int ScheduleAppointmentId { get; set; }

        [Display(Name = "Property Manager ID")]
        public int PropertyManagerId { get; set; }

        [Display(Name = "Tenant ID")]
        public int TenantId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Schedule Appointment Date")]
        public DateTime ScheduleAppointmentDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public PropertyManager PropertyManager { get; set; }
        public Tenant Tenant { get; set; }
    }
}