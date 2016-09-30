using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheet.Entities.Models;

namespace Timesheet.Entities
{
    public class TimesheetEntities : DbContext, ITimesheetContext
    {
        public TimesheetEntities()
        {
        }

        public DbSet<TimeSheetEntity> Timesheet { get; set; } 
    }
}
