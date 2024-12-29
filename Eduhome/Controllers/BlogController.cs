using Eduhome.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class BlogController : Controller
    {
        private readonly EduhomeDbContext _context;

        public BlogController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
