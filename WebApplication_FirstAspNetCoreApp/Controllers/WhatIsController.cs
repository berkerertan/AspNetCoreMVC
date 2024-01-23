using Microsoft.AspNetCore.Mvc;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class WhatIsController : Controller
    {
        public IActionResult RazorSyntax()
        {
            return View();
        }
    }
}
