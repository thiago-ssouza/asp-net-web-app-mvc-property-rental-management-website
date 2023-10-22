using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Building
    {
        [Key]
        public int B_Id { get; set; }

        [Display(Name = "Bulding ID")]
        public int BuildingId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
        
        [Display(Name = "Unit Number")]
        public int UnitNumber { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
