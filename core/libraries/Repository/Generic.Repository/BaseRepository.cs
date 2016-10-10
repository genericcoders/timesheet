using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic.Repository.Interfaces;

namespace Generic.Repository
{
    public class BaseRepository<TEntity, TPrimKey> : IRepository<TEntity, TPrimKey> where TEntity : class//where TEntity : class, IRepository<TEntity, TPrimKey> 
    {
        private readonly IApplicationEntities _context;

        public BaseRepository(IApplicationEntities context)
        {
            _context = context; 
        }

        public bool Create(TEntity item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TPrimKey id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Get()
        {
            return _context.Set<TEntity>();
        }

        public TEntity Get(TPrimKey id)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
