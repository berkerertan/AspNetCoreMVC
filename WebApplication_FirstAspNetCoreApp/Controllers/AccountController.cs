using Microsoft.AspNetCore.Mvc;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class AccountController : Controller
    {
      // /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        //   /Account/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
