using AskMe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AskMe.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        AskContext db = new AskContext();


        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Details(string name = "") {

            User user = db.Users.FirstOrDefault(u => u.Login == name);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);

        }

        public ActionResult Edit(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.Users = db.Users.ToList();
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user, int[] friends)
        {
            User newUser = db.Users.Find(user.Id);
            newUser.Name = user.Name;
            newUser.Surname = user.Surname;

            newUser.FriendUsers.Clear();
            if (friends != null)
            {
                //получаем выбранные курсы
                foreach (var c in db.Users.Where(co => friends.Contains(co.Id)))
                {
                    newUser.FriendUsers.Add(c);
                }
            }

            db.Entry(newUser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}