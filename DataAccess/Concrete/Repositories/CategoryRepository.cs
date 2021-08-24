using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

        public void Add(Category entity)
        {
            _object.Add(entity);
        }

        public void Delete(Category entity)
        {
            _object.Remove(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Category entity)
        {
            c.SaveChanges();
        }
    }
}
