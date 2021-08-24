using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IEntityRepository<T> where T : class, IEntity, new()
    {

        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Add(T entity)
        {
            _object.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            c.SaveChanges();
        }
    }
}
