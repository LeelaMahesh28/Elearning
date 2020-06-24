using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineApp.Models
{
    public class PayDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        public int Uid { get; set; }
        public int Cid { get; set; }
        public string Status { get; set; }
        public DateTime ScheduleDate { get; set; }


    }
}