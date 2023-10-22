using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNetWebAppMvcPRMWebsite.Models
{
    public class User
    {
        [Key]
        public int U_Id { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Role { get; set; }
    }
}