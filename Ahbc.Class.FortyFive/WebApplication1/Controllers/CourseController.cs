using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        private readonly SchoolContext _context = new SchoolContext();

        // GET: Course
        public ActionResult Index()
        {
            var course = _context.Courses;
            return View(course);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course newCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(newCourse);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.Error = "Error! Please Try Again!";
                return View();
            }

        }
    }
}