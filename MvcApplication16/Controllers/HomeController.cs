using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication16.Models;

namespace MvcApplication16.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Avrumi",
                LastName = "Friedman",
                Age = 34
            };

            return View(new PersonViewModel
            {
                Person = person,
            });
        }

        public ActionResult About()
        {
            return View();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
