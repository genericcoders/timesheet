using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheet.Entities.Models;

namespace Timesheet.Entities.Context
{
    public interface ITimesheetEntities
    {

       DbSet<TimesheetEntity> Timesheet { get; set; }
       DbSet<EmployeeEntity> Employee { get; set; }
    }
}
