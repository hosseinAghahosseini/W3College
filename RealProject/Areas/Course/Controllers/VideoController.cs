using Microsoft.AspNetCore.Mvc;
using RealProject.Entities;
using RealProject.Models;
using RealProject.Services;
using System.Diagnostics;

namespace RealProject.Areas.User.Controllers
{
    public class VideoController : Controller
    {
        private readonly AppDbContext _context;
        public VideoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            var qualities = Video.GetQualityList();
            ViewBag.QualityList = qualities;
            return View();
        }
    }
}
