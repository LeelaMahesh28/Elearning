using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "please enter  name")]
        [StringLength(10, MinimumLength = 3)]
        public string AdminName { get; set; }
        [Required(ErrorMessage = "please enter password")]
        [StringLength(10, MinimumLength = 5)]
        public string AdminPassword { get; set; }
    }
}