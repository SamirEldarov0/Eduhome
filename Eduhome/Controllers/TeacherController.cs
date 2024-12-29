using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eduhome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly EduhomeDbContext _context;

        public TeacherController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page=1)
        {
            List<Teacher> teachers = _context.Teachers.Skip((page-1)*6).Take(6).ToList();
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Teachers.Count() / 6d);
            return View(teachers);
        }

        public IActionResult Detail(int id)
        {
            Teacher teacher = _context.Teachers.Include(x=>x.TeacherSkills).FirstOrDefault(x => x.Id == id);
            if (teacher==null)
            {
                return NotFound();
            }
            ViewBag.TeacherSkills = _context.TeacherSkills.Include(x=>x.Teacher).Include(x=>x.Skill).Where(x => x.TeacherId == id);
            return View(teacher);
        }


    }
}
