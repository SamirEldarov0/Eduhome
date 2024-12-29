using Eduhome.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class AccountController : Controller
    {
        private readonly EduhomeDbContext _context;

        public AccountController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
