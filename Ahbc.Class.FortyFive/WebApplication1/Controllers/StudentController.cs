using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;

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

        public ActionResult StudentName(string firstName)
        {
            var student = _context.Students.First(s => s.FirstName == firstName);

            return View(student);
        }
    }
}