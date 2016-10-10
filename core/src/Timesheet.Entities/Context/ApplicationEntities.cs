using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Timesheet.Entities.Models;
using Timesheet.Constants;

namespace Timesheet.Entities.Context
{
	public partial class ApplicationEntities : TimesheetEntities, IApplicationEntities
	{

		public ApplicationEntities(DbContextOptions options)
			: base(options)
		{

		}
	}
}
