﻿using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepositories<Staff>, IStaffDal
    {
        public EfStaffDal(MyContext? context) : base(context)
        {
        }

        public async Task<int> GetStaffCount()
        {
            return await _dbSet.CountAsync();
            //return await _context.Set<Staff>().CountAsync();
        }
    }
}
