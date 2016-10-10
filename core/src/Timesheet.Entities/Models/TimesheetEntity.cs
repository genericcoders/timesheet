using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Entities.Models
{
	public class TimesheetEntity
	{
		public int Id { get; set; }
		public int LocationId { get; set; }
		public int EmployeeId { get; set; }
		public int TotalHoursWorked { get; set; }
		public System.DateTime DateAdded { get; set; }
		public string AddedBy { get; set; }
		public System.DateTime DayWorked { get; set; }
		public bool IsPto { get; set; }

		//public virtual Employee Employee { get; set; }
		//public virtual Location Location { get; set; }
	}
}
