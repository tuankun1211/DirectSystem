using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace DirectSystem.Web.Models
{
    public class AccountModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
