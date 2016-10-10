using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? SupervisorId { get; set; }
        public bool? Active { get; set; }

        //public virtual TimesheetDto TimeSheet { get; set; }
    }
}
