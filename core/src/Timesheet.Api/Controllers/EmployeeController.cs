using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timesheet.Services.Interfaces;
using Timesheet.Dto;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Timesheet.Api.Controllers
{
	[Route("api/employee")]
	public class EmployeeController : Controller
	{
		private readonly IEmployeeService _employeeSvc;
		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeSvc = employeeService;
		}
		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			var employees = _employeeSvc.GetAll();
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public IActionResult Post([FromBody]EmployeeDto employeeDto)
		{
			_employeeSvc.Add(employeeDto);
			return Ok();
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		[HttpPatch("{id}")]
		public void Patch(int id, [FromBody] EmployeeDto employeeDto)
		{
			
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
