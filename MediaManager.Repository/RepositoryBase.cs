using MediaManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaManager.Entity
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected MediaManagerContext _context;

        public void Dispose()
        {}

        public RepositoryBase(MediaManagerContext context)
        {
            _context = context;
        }

        public abstract void Delete(int id);

        public abstract T Get(int id);

        public virtual List<T> GetAll() => _context.Set<T>().ToList();

        public abstract void Save(T element);
    }
}
