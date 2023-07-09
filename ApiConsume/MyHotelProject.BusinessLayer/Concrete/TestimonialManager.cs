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
    public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService
    {
        public TestimonialManager(IGenericDal<Testimonial>? genericdal) : base(genericdal)
        {
        }
    }
}
