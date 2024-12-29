using Eduhome.DAL;
using Eduhome.Helpers;
using Eduhome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eduhome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly EduhomeDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(EduhomeDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            if (sliders==null)
            {
                return NotFound();
            }
            return View(sliders);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.ImgFile==null)
            {
                ModelState.AddModelError("ImgFile", "Required");
                return View();
            }
            else
            {
                if (slider.ImgFile.ContentType!="image/jpeg"&&slider.ImgFile.ContentType!="image/png")
                {
                    ModelState.AddModelError("ImgFile", "Faylin formati yanlisdir");
                    return View();
                }
                if (slider.ImgFile.Length> 2097152)
                {
                    ModelState.AddModelError("ImgFile", "Faylin uzunlugu 2 Mb-dan cox ola bilmez");
                    return View();
                }
                slider.BgImg = FileManager.Save(_env.WebRootPath, "assets/uploads/sliders", slider.ImgFile);
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction("index");
        }




    }
}
