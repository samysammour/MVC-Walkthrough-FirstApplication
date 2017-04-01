using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;

namespace FirstApplication.Controllers
{
    public class StudentController : Controller
    {
        private MvcContext _context = new MvcContext();
        // GET: Strudent
        public ActionResult Index()
        {
            var list = _context.Students.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            Student std = new Student();
            return View(std);
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return RedirectToAction("Index", "Student");
            }
            return View(student);
        }
    }
}