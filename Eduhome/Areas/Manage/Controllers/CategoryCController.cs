using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eduhome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryCController : Controller
    {
        private readonly EduhomeDbContext _context;

        public CategoryCController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.CategoryCs.Count() / 3d);
            List<CategoryC> categoryCs = _context.CategoryCs.Include(x => x.Courses).Skip((page-1)*3).Take(3).ToList();
            return View(categoryCs);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryC categoryC)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.CategoryCs.Add(categoryC);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            CategoryC categoryC = _context.CategoryCs.FirstOrDefault(x => x.Id == id);
            if (categoryC==null)
            {
                return NotFound();
            }
            return View(categoryC);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryC categoryC)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            CategoryC existCategory = _context.CategoryCs.FirstOrDefault(x => x.Id == categoryC.Id);
            if (existCategory==null)
            {
                return NotFound();
            }
            existCategory.Name = categoryC.Name;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            CategoryC categoryC = _context.CategoryCs.FirstOrDefault(x => x.Id == id);
            if (categoryC==null)
            {
                return Json(new { status = 404 });
            }
            _context.CategoryCs.Remove(categoryC);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }



    }
}
