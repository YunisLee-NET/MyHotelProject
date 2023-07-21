using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.BusinessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.EntityFramework;
using MyHotelProject.DataAccessLayer.Repositories;

namespace MyHotelProject.WebApi.ProjectStartUp
{
    public static class DependencySetUp
    {
        public static void CustomService(this IServiceCollection services)
        {
            services.AddDbContext<MyContext>();

            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepositories<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IStaffDal, EfStaffDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();

            services.AddScoped<ISubscribeService, SubscribeManager>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();
        }
    }
}
