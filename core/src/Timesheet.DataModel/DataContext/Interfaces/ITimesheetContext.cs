using Microsoft.EntityFrameworkCore;
using Timesheet.Service.Models;

namespace Timesheet.Entities
{
    public interface ITimesheetContext
    {
        DbSet<TimeSheetEntity> Timesheet { get; set; }
    }
}