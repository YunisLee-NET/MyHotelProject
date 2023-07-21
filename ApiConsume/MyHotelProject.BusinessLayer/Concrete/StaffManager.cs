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
    public class StaffManager : GenericManager<Staff>, IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IGenericDal<Staff>? genericdal, IStaffDal staffDal) : base(genericdal)
        {
            _staffDal = staffDal;
        }

        public async Task<int> GetStaffAsync()
        {
            return await _staffDal.GetStaffCount();
        }
    }
}
