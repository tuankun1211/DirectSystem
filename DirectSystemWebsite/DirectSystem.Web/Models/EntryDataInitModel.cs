using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DirectSystem.Web.Models
{
    public class EntryDataInitModel
    {
        [Display(Name="Date Time")]
        public DateTime InitDateTime { get; set; }

        [Display(Name = "Promotion")]
        public bool IsPromotion { get; set; }
    }
}