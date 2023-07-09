using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : GenericManager<Service>, IServiceService
    {
        public ServiceManager(IGenericDal<Service>? genericdal) : base(genericdal)
        {
        }
    }
}
