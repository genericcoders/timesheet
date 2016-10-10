using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Constants
{
	public class TimesheetConfig
	{
		public const string ConnectionString =
			"Server=TERMINAL;Database=Timesheet;Trusted_Connection=true;MultipleActiveResultSets=true;";

		public const string DefaultSort = "date";
		public const int MaxPageSize = 20;
		public const int DefaultPage = 1;
	}
}
