//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DirectSystem.Web.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_CustomerBehavior
    {
        public string BehaviorID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> SaleNumber { get; set; }
        public Nullable<int> Index_Part1 { get; set; }
        public Nullable<int> Index_Part2 { get; set; }
        public Nullable<int> Index_Part3 { get; set; }
        public Nullable<int> Index_Part4 { get; set; }
        public Nullable<int> Index_Part5 { get; set; }
        public Nullable<int> Index_Part6 { get; set; }
        public Nullable<int> Index_Part7 { get; set; }
        public Nullable<int> Index_Part8 { get; set; }
        public Nullable<int> Index_Part9 { get; set; }
        public Nullable<int> Index_Part10 { get; set; }
        public Nullable<int> CustomerComplaints { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
    
        public virtual tbl_CustomerInfo tbl_CustomerInfo { get; set; }
    }
}
