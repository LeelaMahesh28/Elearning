using Antlr.Runtime.Misc;
using OnlineApp.Models;
using System;
using System.Configuration;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;


namespace OnlineApp.Controllers
{
    public class UserController : Controller
    {
        private UserContext _context;

        // GET: User
        public UserController()
        {
            this._context = new UserContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        public ActionResult ViewUsers()
        {
            return View(_context.Users.ToList());
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Users us = _context.Users.Find(id);
            if (us == null)
            {
                return HttpNotFound();
            }
            return View(us);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Users us = _context.Users.Find(id);
            _context.Users.Remove(us);
            _context.SaveChanges();
            return RedirectToAction("ViewUsers");
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users obj)
        {
            if (ModelState.IsValid)
            {
                using (UserContext db = new UserContext())
                {
                    db.Users.Add(obj);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = obj.UserName + " " + " sucessfully registered.";
            }
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Users user)
        {
            using (UserContext db = new UserContext())
            {
                var usr = db.Users.SingleOrDefault(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);
                if (usr != null)
                {
                    Session["UserId"] = usr.UserId.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password is wrong.");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
