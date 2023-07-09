using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        protected readonly MyContext? _context;
        protected readonly DbSet<T>? _dbSet;

        public GenericRepositories(MyContext? context)
        {
            _context = context;
            _dbSet= _context?.Set<T>();
        }

        public void Delete(T t)
        {
            _context?.Remove(t);
            _context?.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetList()
        {
            return _dbSet.ToList();
        }

        public void Insert(T t)
        {
            _context?.Add(t);
            _context?.SaveChanges();
        }

        public void Update(T t)
        {
            _context?.Update(t);
            _context?.SaveChanges();
        }
    }
}
