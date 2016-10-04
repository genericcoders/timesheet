using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Entities.Context;
using Timesheet.Services.Interfaces;


namespace Timesheet.Services
{
    public class TimesheetService : ITimesheetService
    {
        //TODO: Implement Repository
        private readonly ITimesheetEntities _db;

        public TimesheetService(ITimesheetEntities timesheetEntities)
        {
            _db = timesheetEntities; 
        }

    }
}
