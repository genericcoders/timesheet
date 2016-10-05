using System.Collections.Generic;
using Timesheet.Dto;

namespace Timesheet.Services.Interfaces
{
	public interface IEmployeeService
	{
		IEnumerable<EmployeeDto> GetAll();
		EmployeeDto Add(EmployeeDto dtoEmployee);
	}
}
