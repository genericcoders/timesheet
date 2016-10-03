using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheet.Entities.Models;

namespace Timesheet.Entities.Context
{
    public class TimesheetEntities : DbContext, ITimesheetEntities
    {

        public DbSet<TimesheetEntity> Timesheet { get; set; }
        public DbSet<EmployeeEntity> Employee { get; set; }
    }
}
