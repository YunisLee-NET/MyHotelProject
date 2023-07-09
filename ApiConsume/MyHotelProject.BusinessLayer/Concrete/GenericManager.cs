using Microsoft.EntityFrameworkCore;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        protected readonly IGenericDal<T>? _genericdal;

        public GenericManager(IGenericDal<T>? genericdal)
        {
            _genericdal = genericdal;
        }

        public void TDelete(T t)
        {
            _genericdal?.Delete(t);
        }

        public T TGetByID(int id)
        {
            return _genericdal?.GetByID(id);
        }

        public List<T> TGetList()
        {
            return _genericdal?.GetList();
        }

        public void TInsert(T t)
        {
            _genericdal?.Insert(t);
        }

        public void TUpdate(T t)
        {
            _genericdal?.Update(t);
        }
    }
}
