using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Appointment
    {
        [Key]
        public int APoin_Id { get; set; }

        [Display(Name = "Appointment ID")]
        public int AppointmentId { get; set; }

        [Display(Name = "Apartment ID")]
        public int ApartmentId { get; set; }

        [Display(Name = "Tenant ID")]
        public int TenantId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public Apartment Apartment { get; set; }
        public Tenant Tenant { get; set; }
    }
}
