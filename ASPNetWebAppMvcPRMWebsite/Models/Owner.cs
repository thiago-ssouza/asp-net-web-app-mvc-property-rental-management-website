using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Owner
    {
        [Key]
        public int O_Id { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }

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

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
