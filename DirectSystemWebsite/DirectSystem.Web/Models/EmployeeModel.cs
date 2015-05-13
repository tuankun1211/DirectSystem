using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectSystem.Web.Models
{
    public class EmployeeModel
    {
        public string EmpID { get; set; }
        public string EmpCode { get; set; }
        public string ShifName { get; set; }
        public int? AbsenceInShif { get; set; }
        public int? OnPhone { get; set; }
        public int? Chatting { get; set; }
        public int? UseComputer { get; set; }
        public int? SlowRepresentative { get; set; }
        public int? CustomerComplaint { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateBy { get; set; }
        public DateTime? PostDate { get; set; }

        public List<SessionModel> EmployeeSession { get; set; }
    }
}