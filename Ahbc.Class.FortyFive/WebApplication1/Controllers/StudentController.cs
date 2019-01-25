using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class StudentController : Controller
    {
        private readonly SchoolContext _context = new SchoolContext();

        // GET: Student
        public ActionResult Index()
        {
            var student = _context.Students;

            return View(student);
        }

        public ActionResult OneStudent(int id)
        {
            var student = _context.Students.First(s => s.ID == id);

            return View(student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student newStudent)
        {

            if (ModelState.IsValid)
            {
                //Add newStudent to the Student table

                _context.Students.Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "The Information you entered was not valid.";
                return View();
            }
        }

        public ActionResult StudentName(string firstname)
        {
            var student = _context.Students.Where(s => s.FirstName == firstname).First<Student>();

            return View(student);
        }
    }
}