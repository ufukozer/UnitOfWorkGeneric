using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly DbSet<T> _entities;
        public Repository (XContext xContext)
        {
            _entities = xContext.Set<T>();
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public IEnumerable<T> GetAll(int id)
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

    }
}
