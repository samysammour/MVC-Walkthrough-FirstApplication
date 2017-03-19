using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "Alice";

            Person person2 = new Person {Id = 2, Name = "John"};

            List<Person> list = new List<Person>();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Team()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}