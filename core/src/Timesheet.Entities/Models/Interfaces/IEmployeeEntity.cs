using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Entities.Models.Interfaces
{
    public interface IEmployeeEntity
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        DateTime? DateAdded { get; set; }
        int? SupervisorId { get; set; }
        bool? Active { get; set; }

        //virtual ITimesheetEntity TimeSheet { get; set; }
    }
}
