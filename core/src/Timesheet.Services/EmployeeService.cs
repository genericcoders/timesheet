using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Dto.Employee> GetAll()
        {
            var employees = _db.Employee.Where(x=>x.Active == true);

            return employees.Select(EntityToDtoModel);
        }


        private static Dto.Employee EntityToDtoModel(EmployeeEntity employeeEntity)
        {
            //TODO: Implement AutoMapper
            return new Dto.Employee()
            {
                Active = employeeEntity.Active,
                FirstName = employeeEntity.FirstName,
                Id = employeeEntity.Id,
                LastName = employeeEntity.LastName
            };
        }
    }
}
