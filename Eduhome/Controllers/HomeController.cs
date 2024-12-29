using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eduhome.Controllers
{
    public class HomeController : Controller
    {
        private readonly EduhomeDbContext _context;

        public HomeController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders=_context.Sliders.ToList(),
                Features=_context.Features.ToList(),
                NoticeBoards = _context.NoticeBoards.ToList(),
                Courses = _context.Courses.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Events = _context.Events.ToList(),
            };
            return View(homeViewModel);
        }
        public IActionResult About()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                NoticeBoards = _context.NoticeBoards.ToList(),
                Teachers = _context.Teachers.ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };

            return View(homeViewModel);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
