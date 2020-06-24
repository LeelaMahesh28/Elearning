using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineApp.Models
{
    public class QRCodeModel
    {
        [Key]
        [Display(Name = "QRCode Text")]
        public string QRCodeText { get; set; }


        [Display(Name = "QRCode Image")]
        public string QRCodeImagePath { get; set; }

    }
}