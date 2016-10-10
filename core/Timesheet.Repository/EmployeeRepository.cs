using Generic.Repository;
using Generic.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Entities.Models;

namespace Timesheet.Repository
{
    public class EmployeeRepository : BaseRepository<EmployeeEntity, int>
    {

        private readonly IApplicationEntities _context;

        public EmployeeRepository(IApplicationEntities context)
            : base(context)
        {
            _context = context;
        }
    }

}
