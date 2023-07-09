using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.BusinessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.EntityFramework;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.WebApi.ProjectStartUp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<MyContext>(opt =>
//{
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb"), opt =>
//    {
//        opt.MigrationsAssembly("MyHotelProject.DataAccessLayer");
//    });
//});
//builder.Services.AddDbContext<MyContext>();
//builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepositories<>));
//builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
//builder.Services.AddScoped<IStaffDal, EfStaffDal>();
//builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.CustomService();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
