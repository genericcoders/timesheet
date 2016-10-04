using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Dto;
using Timesheet.Entities.Context;
using Timesheet.Entities.Models;
using Timesheet.Services.Interfaces;

namespace Timesheet.Services
{
	public class EmployeeService : IEmployeeService
	{
		//TODO: Implement Repository
		private readonly ITimesheetEntities _db;

		public EmployeeService(ITimesheetEntities timesheetEntities)
		{
			_db = timesheetEntities;
		}

		public IEnumerable<EmployeeDto> GetAll()
		{
			var employees = _db.Employee.Where(x => x.Active == true);

			return employees.Select(EntityToDtoModel);
		}

		public EmployeeEntity Add(EmployeeDto dtoEmployee)
		{
			var employeeEntity = DtoModelToEntity(dtoEmployee);
			_db.Employee.Add(employeeEntity);
			_db.Complete();
			return employeeEntity;
		}


		private static EmployeeDto EntityToDtoModel(EmployeeEntity employeeEntity)
		{
			//TODO: Implement AutoMapper
			return new EmployeeDto()
			{
				Active = employeeEntity.Active,
				FirstName = employeeEntity.FirstName,
				Id = employeeEntity.Id,
				LastName = employeeEntity.LastName
			};
		}

		private static EmployeeEntity DtoModelToEntity(EmployeeDto dtoEmployee)
		{
			//TODO: Implement AutoMapper
			return new EmployeeEntity()
			{
				Active = dtoEmployee.Active,
				FirstName = dtoEmployee.FirstName,
				Id = dtoEmployee.Id,
				LastName = dtoEmployee.LastName
			};
		}
	}
}
