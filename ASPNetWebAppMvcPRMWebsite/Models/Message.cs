using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCorePRMWebsite.Models
{
    public class Message
    {
        [Key]
        public int M_Id { get; set; }

        [Display(Name = "Message ID")]
        public int MessageId { get; set; }

        [Display(Name = "Apartment ID")]
        public int ApartmentId { get; set; }

        [StringLength(500)]
        [Display(Name = "Message Text")]
        public string MessageText { get; set; }

        [Display(Name = "Tenant ID")]
        public int TenantId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Sent By")]
        public string SentBy { get; set; }

        public Apartment Apartment { get; set; }

        public Tenant Tenant { get; set; }
    }
}
