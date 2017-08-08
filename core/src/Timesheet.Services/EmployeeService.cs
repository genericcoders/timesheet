using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Dto;
using Timesheet.Entities.Models;
using Timesheet.Services.Interfaces;
using Generic.Repository.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Timesheet.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IRepository<EmployeeEntity, int> _employeeRepo;
		private readonly IMapper _mapper;

		public EmployeeService(IRepository<EmployeeEntity, int> employeeRepository, IMapper mapper)
		{
			_employeeRepo = employeeRepository;
			_mapper = mapper;
		}

		public List<EmployeeDto> GetAll()
		{
			var employees = _employeeRepo.Get()
										.Where(x => x.Active == true)
										.Select(x => _mapper.Map<EmployeeEntity, EmployeeDto>(x));
			return employees.ToList();
		}

		public EmployeeDto Add(EmployeeDto employeeDto)
		{
			var employeeEntity = _mapper.Map<EmployeeDto, EmployeeEntity>(employeeDto);
			var isCreated = _employeeRepo.Create(employeeEntity);
			return employeeDto;
		}

		public bool Delete(EmployeeDto emplotDto)
		{
			bool isDeleted =_employeeRepo.Delete(emplotDto.Id);

			return isDeleted; 
		}


		//private static EmployeeDto EntityToDtoModel(EmployeeEntity employeeEntity)
		//{
		//    //TODO: Implement AutoMapper
		//    return new EmployeeDto()
		//    {
		//        Active = employeeEntity.Active,
		//        FirstName = employeeEntity.FirstName,
		//        Id = employeeEntity.Id,
		//        LastName = employeeEntity.LastName
		//    };
		//}

		//private static EmployeeEntity DtoModelToEntity(EmployeeDto dtoEmployee)
		//{
		//    //TODO: Implement AutoMapper
		//    return new EmployeeEntity()
		//    {
		//        Active = dtoEmployee.Active,
		//        FirstName = dtoEmployee.FirstName,
		//        Id = dtoEmployee.Id,
		//        LastName = dtoEmployee.LastName
		//    };
		//}
	}
}
