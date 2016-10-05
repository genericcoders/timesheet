using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Timesheet.Entities.Models;
using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Timesheet.Entities.Context
{
	public interface ITimesheetEntities : IDisposable
	{

		DbSet<TimesheetEntity> Timesheet { get; set; }
		DbSet<EmployeeEntity> Employee { get; set; }

		void Complete();
	}
}
