using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Repository.Interfaces
{
    public interface IRepository<TEntity, TPrimKey> where TEntity : class
    {
        bool Create(TEntity item);
        IQueryable<TEntity> Get();
        TEntity Get(TPrimKey id);
        bool Update(TEntity item);
        bool Delete(TPrimKey id);
    }
}
