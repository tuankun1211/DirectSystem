using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectSystem.Web.Models
{
    public class CustomerInfoModel
    {
        public string CustomerID { get; set; }
        public string StoreCode { get; set; }
        public int? EntryNumber { get; set; }
        public int? ForeignNumber { get; set; }
        public int? AgeGroup1 { get; set; }
        public int? AgeGroup2 { get; set; }
        public int? AgeGroup3 { get; set; }
        public int? GenderMale { get; set; }
        public int? GenderFemale { get; set; }
        public int? Index_Pathway1 { get; set; }
        public int? Index_Pathway2 { get; set; }
        public int? Index_Pathway3 { get; set; }
        public string ShifName { get; set; }
        public string CustomerCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? PostDate { get; set; }

        public List<CustomerBehaviorModel> CustomerBehaviorModels { get; set; }

        public List<SessionModel> CustomerSession { get; set; }
    }
}