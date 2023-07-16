using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<MyContext>();
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
