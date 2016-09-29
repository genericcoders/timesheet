using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Service.Models
{
    public partial class TimeSheet
    {
        public int TimeSheetId { get; set; }
        public int LocationId { get; set; }
        public int EmployeeId { get; set; }
        public int SupervisorId { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public decimal Hours { get; set; }
        public System.DateTime DateOfWork { get; set; }
        public string Notes { get; set; }
        public bool WasOffSite { get; set; }

        //public virtual Employee Employee { get; set; }
        //public virtual Location Location { get; set; }
    }
}
