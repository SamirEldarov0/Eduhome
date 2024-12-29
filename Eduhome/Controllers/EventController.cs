using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eduhome.Controllers
{
    public class EventController : Controller
    {
        private readonly EduhomeDbContext _context;

        public EventController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId,int page=1)
        {
            var query = _context.Events.AsQueryable();


            if (query!=null&&categoryId!=null)
            {
                query = query.Where(x => x.CategoryEId == categoryId);
            }

            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(query.Count() / 4d);
            ViewBag.CategoryId = categoryId;
            List<Event> events = query.Skip((page-1)*4).Take(4).ToList();

            return View(events);
        }
        public IActionResult Detail(int id=5)
        {
            Event detailedEvent=_context.Events.FirstOrDefault(x=>x.Id == id);
            ViewBag.EventSpeakers = _context.EventSpeakers.Include(x=>x.Speaker).Where(x => x.EventId == id).ToList();
            ViewBag.Categories = _context.CategoryEs.Include(x => x.Events).ToList();
            
            return View(detailedEvent);
        }
    }
}
