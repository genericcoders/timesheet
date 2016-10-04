using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheet.Entities.Models;
using Timesheet.Constants;

namespace Timesheet.Entities.Context
{
	public class TimesheetEntities : DbContext, ITimesheetEntities
	{
		//TODO: Dependency inject configuration
		public TimesheetEntities(DbContextOptions options)
			: base(options)
		{

		}

		public DbSet<TimesheetEntity> Timesheet { get; set; }
		public DbSet<EmployeeEntity> Employee { get; set; }
		public object Configuration { get; private set; }

		public void Complete()
		{
			SaveChanges();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			//TODO: Dependency inject this from the config
			optionsBuilder.UseSqlServer(TimesheetConfig.ConnectionString);
		}
	}
}
