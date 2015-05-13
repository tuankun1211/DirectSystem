using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectSystem.Web.Models
{
    public class EntryDataModel
    {
        public CustomerInfoModel CustomerInfo { get; set; }

        public EmployeeModel Employee { get; set; }
    }
}