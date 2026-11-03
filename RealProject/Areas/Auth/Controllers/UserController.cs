using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RealProject.Models;

namespace RealProject.Areas.User.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
