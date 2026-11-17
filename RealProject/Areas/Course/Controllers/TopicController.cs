using Microsoft.AspNetCore.Mvc;
using RealProject.Entities;
using RealProject.Models;
using RealProject.Services;
using System.Diagnostics;

namespace RealProject.Areas.User.Controllers
{
    public class TopicController : Controller
    {
        private readonly AppDbContext _context;
        public TopicController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int Id, int PageNum = 1, int PageSize = 3)
        {
            TopicService service = new TopicService(_context);

            var res = service.GetTopicsByCourseId(Id, PageNum, PageSize);
            var count = service.GetCountTopicByCourseId(Id);

            if (res.Any())
            {
                ViewBag.CourseName = res[0].Course.Name;
                ViewBag.CourseId = res[0].CourseId;
                ViewBag.PageCount = Math.Ceiling((double)count / (double)PageSize);
            }
            else
            {
                ViewBag.CourseName = "عنوان یافت نشد.";
            }

            return View(res);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Topic Model)
        {
            TopicService service = new TopicService(_context);
            var res = service.Create(Model);
            if(res > 0)
            {

            }
            else
            {

            }

            return View();
        }

        public IActionResult Edit(int Id)
        {
            TopicService TopicService = new TopicService(_context);
            var course = TopicService.ReadSingle(Id);
            if (course == null)
                return RedirectToAction("Index", new {Message = "error"});

            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Topic Model)
        {
            TopicService TopicService = new TopicService(_context);
            var res = TopicService.Update(Model);
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
            TopicService TopicService = new TopicService(_context);
            var res = TopicService.DeleteById(Id);
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
