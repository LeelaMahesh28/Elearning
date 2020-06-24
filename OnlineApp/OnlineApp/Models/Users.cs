using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineApp.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "please enter  id")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "please enter  name")]
        [StringLength(10, MinimumLength = 3)]
        public string UserName { get; set; }



        [Required(ErrorMessage = "please enter  password")]
        [StringLength(10, MinimumLength = 5)]
        public string UserPassword { get; set; }
    }
}