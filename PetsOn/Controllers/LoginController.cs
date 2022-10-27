using Microsoft.AspNetCore.Mvc;
using PetsOn.Models;
using System.Diagnostics;

namespace PetsOn.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

    }
}