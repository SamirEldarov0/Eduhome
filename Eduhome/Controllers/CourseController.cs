using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eduhome.Controllers
{
    public class CourseController : Controller
    {
        private readonly EduhomeDbContext _context;

        public CourseController(EduhomeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId,int? tagId, string sort= "FromAToZ", int page=1)
        {

            var query = _context.Courses.AsQueryable();
            if (query!=null&&categoryId!=null)
            {
                query = query.Where(x => x.CategoryCId == categoryId);
            }
            //if (tagId != null)
            //{
            //    query=query.Where(x=>x.CourseTags.Where(x=>x.TagId==tagId));
            //    //book.TagIds = book.BookTags.Select(x => x.TagId).ToList();
            //    List<CourseTag> courseTags = _context.CourseTags.Include(x => x.Tag).Where(x => x.TagId == tagId).ToList();
            //    List<int> tagIds = new List<int>();
            //    foreach (var item in courseTags)
            //    {
            //        tagIds.Add(item.TagId);
            //    }
            //    query = query.Where(x => x.CourseTags == courseTags);
            //    query = query.Where(x => x.CourseTags == courseTags);
            //    //query=query.Where(x=>x.CourseTags.Contains(courseTags));
            //}
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "FromAToZ":
                        query = query.OrderBy(x => x.Name);
                        break;
                    case "FromZToA":
                        query = query.OrderByDescending(x => x.Name);
                        break;
                    case "LowToHigh":
                        query = query.OrderBy(x => x.Price);
                        break;
                    case "HighToLow":
                        query = query.OrderByDescending(x => x.Price);
                        break;
                    default:
                        break;
                }

            }


            ViewBag.CategoryId = categoryId;
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(query.Count() / 3d);
            ViewBag.Sort = sort;
            List<Course> courses = query.Skip((page - 1) * 3).Take(3).ToList();
            return View(courses);
        }
        public IActionResult Detail(int id=1)
        {
            Course course = _context.Courses.FirstOrDefault(x => x.Id==id);
            if (course==null) { return NotFound(); }

            ViewBag.Categories = _context.CategoryCs.Include(x=>x.Courses).ToList();
            ViewBag.Tags = _context.Tags.Include(x=>x.CourseTags).ToList();
           
            //ViewBag.CourseTags = _context.CourseTags.Where(x => x.CourseId == id).ToList();
            return View(course);
        }



        //public IActionResult Show()
        //{
        //    CategoryE categoryE = _context.CategoryEs.Include(x=>x.Events).FirstOrDefault(x=>x.Id==9);
        //    List<Event> events = categoryE.Events.ToList();
        //    return Json(events);
        //    return Content($"Count - {categoryE.Events.Count()}");
        //}
        public IActionResult Show()
        {
            CategoryC category = _context.CategoryCs.Include(x => x.Courses).FirstOrDefault(x => x.Id == 5);
            List<Course> courses = category.Courses.ToList();
            return Json(courses);
            //return Content($"Count - {categoryE.Events.Count()}");
        }



    }
}
