using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCorePRMWebsite.Models
{
    public class ReportEvent
    {
        [Key]
        public int RE_Id { get; set; }

        [Display(Name = "Report Event ID")]
        public int ReportEventId { get; set; }

        [Display(Name = "Apartment ID")]
        public int ApartmentId { get; set; }

        [StringLength(500)]
        [Display(Name = "Event Text")]
        public string EventText { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        public Apartment Apartment { get; set; }
    }
}
