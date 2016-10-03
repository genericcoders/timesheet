using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Dto.Employee> GetAll();
    }
}
