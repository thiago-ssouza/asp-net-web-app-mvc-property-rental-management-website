using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Apartment
    {
        [Key]
        public int A_Id { get; set; }

        [Display(Name = "Apartment ID")]
        public int ApartmentId { get; set; }

        [Display(Name = "Building ID")]
        public int BuildingId { get; set; }

        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }

        [Display(Name = "Property Manager ID")]
        public int PropertyManagerId { get; set; }

        [Display(Name = "Apartment Unit Number")]
        public int ApartmentUnitNumber { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int Size { get; set; }

        public decimal Price { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public Building Building { get; set; }
        public Owner Owner { get; set; }
        public PropertyManager PropertyManager { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<ReportEvent> ReportEvents { get; set; }

    }
}
