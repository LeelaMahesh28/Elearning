using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineApp.Models
{
    public class CourseDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegId { get; set; }
        public int UsId { get; set; }
        public int CoId { get; set; }
        public string CoName { get; set; }
        public string CoDept { get; set; }
    }
}