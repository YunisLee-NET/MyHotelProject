using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebUI.Models;

namespace MyHotelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _appUserSignIn;

        public LoginController(SignInManager<AppUser> appUserSignIn)
        {
            _appUserSignIn = appUserSignIn;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _appUserSignIn.PasswordSignInAsync(model.Username, model.Password, false, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Staff");
                }
            }
            return View();
        }
    }
}
