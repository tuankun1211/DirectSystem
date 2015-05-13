using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectSystem.Web.Models
{
    public class CustomerBehaviorModel
    {
        public string BehaviorID { get; set; }
        public string CustomerID { get; set; }
        public int? SaleNumber { get; set; }
        public int? Index_Part1 { get; set; }
        public int? Index_Part2 { get; set; }
        public int? Index_Part3 { get; set; }
        public int? Index_Part4 { get; set; }
        public int? Index_Part5 { get; set; }
        public int? Index_Part6 { get; set; }
        public int? Index_Part7 { get; set; }
        public int? Index_Part8 { get; set; }
        public int? Index_Part9 { get; set; }
        public int? Index_Part10 { get; set; }
        public int? CustomerComplaints { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}