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
            InstructorService service = new InstructorService(_context);
            var instructors = service.ReadAll();

            ViewBag.Instructors = instructors;
            ViewData["Instructors"] = instructors;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Course Model)
        {
            CourseService courseService = new CourseService(_context);
            var res = courseService.Create(Model);
            if(res > 0)
            {
                return RedirectToAction("Index", new { Message = "success" });
            }
            else
            {
                return RedirectToAction("Index", new { Message = "error" });
            }
        }

        public IActionResult Edit(int Id)
        {
            CourseService courseService = new CourseService(_context);
            var course = courseService.Read(Id);
            if (course == null)
                return RedirectToAction("Index", new {Message = "error"});

            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course Model)
        {
            CourseService courseService = new CourseService(_context);
            var res = courseService.Update(Model);
            if (res > 0)
            {
                return RedirectToAction("Index", new { Message = "success" });
            }
            else
            {
                return RedirectToAction("Index", new { Message = "error" });
            }
        }

        public IActionResult Delete(int Id)
        {
            CourseService courseService = new CourseService(_context);
            var res = courseService.Delete(Id);
            if (res > 0)
                return RedirectToAction("Index", new { Message = "success" });
            else
                return RedirectToAction("Index", new { Message = "error" });
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
