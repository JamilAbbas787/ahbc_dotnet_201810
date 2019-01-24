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
            var student = _context.Students
                .Where(s => s.ID >= 1 && s.ID <= 3)
                .FirstOrDefault().ToString();

            var test = 2;
            return View();
        }
    }
}