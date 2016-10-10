using System.Collections.Generic;
using Timesheet.Dto;

namespace Timesheet.Services.Interfaces
{
	public interface IEmployeeService
	{
		List<EmployeeDto> GetAll();
		EmployeeDto Add(EmployeeDto dtoEmployee);
	}
}
