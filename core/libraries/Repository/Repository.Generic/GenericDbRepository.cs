using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic
{
    public class GenericRepository<TRepo> where TRepo : class
    {
        protected readonly DbContext dbContext;
        protected DbSet<TRepo> dbSet; 
        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<TRepo>();
        }

        public void Add(TRepo entity)
        {
            dbContext.Set<TRepo>().Add(entity);
        }
    }

    public interface IDbContext
    {

    }

    //public class TimesheetDbContext: TimesheetContext

    //internal interface IDbContext : DbContext
    //{
    //}
}
