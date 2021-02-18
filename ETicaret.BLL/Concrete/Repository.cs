using ETicaret.BLL.Abstract;
using ETicaret.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BLL.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        private readonly DataContext _dbContext = new DataContext();

        public Repository()
        {
            _objectSet = _dbContext.Set<T>();
        }

        public void Delete(int id)
        {
            //var model = _objectSet.Find(id);
            //_objectSet.Remove(model);
            _objectSet.Remove(FindGetById(id));
            Save();
        }

        public T FindGetById(int id)
        {
            return _objectSet.Find(id);
        }

        public void Insert(T deger)
        {
            _objectSet.Add(deger);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T deger)
        {
            Save();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }
    }
}
