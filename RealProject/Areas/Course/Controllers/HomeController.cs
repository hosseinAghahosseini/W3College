using Microsoft.AspNetCore.Mvc;
using RealProject.Entities;
using RealProject.Models;
using RealProject.Services;
using System.Diagnostics;

namespace RealProject.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CourseService courseService = new CourseService(_context);
            var res = courseService.ReadAll();
            return View(res);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course Model)
        {
            CourseService courseService = new CourseService(_context);
            var res = courseService.Create(Model);
            if(res > 0)
            {

            }
            else
            {

            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
