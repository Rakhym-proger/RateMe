using AskMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AskMe.Controllers
{
    public class HomeController : Controller
    {

        AskContext db = new AskContext();

        [Authorize]
        public ActionResult Index()
        {

            var users = db.Users;

            ViewBag.Users = users;


            return View();
        }


        [Authorize]
        public ActionResult Friends()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Messages()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}