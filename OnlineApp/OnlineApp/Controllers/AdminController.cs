using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineApp.Models;

namespace OnlineApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private UserContext _context;
        public AdminController()
        {
            this._context = new UserContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            using (UserContext db = new UserContext())
            {
                var usr = db.Admins.SingleOrDefault(u => u.AdminName == admin.AdminName && u.AdminPassword == admin.AdminPassword);
                if (usr != null)
                {
                    Session["AdminId"] = usr.AdminId.ToString();
                    Session["AdminName"] = usr.AdminName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["AdminId"] != null)
            {
                return View(); 
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult ViewAdminCourses()
        {
            return View(_context.Courses.ToList());
        }


        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course obj)
        {
            if (ModelState.IsValid)
            {
                using (UserContext db = new UserContext())
                {
                    db.Courses.Add(obj);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = obj.CourseName + " " + " sucessfully registered.";
            }
            return View();
        }

        public ActionResult RemoveCourse(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Course us = _context.Courses.Find(id);
            if (us == null)
            {
                return HttpNotFound();
            }
            return View(us);
        }

        [HttpPost]
        public ActionResult RemoveCourse(int id)
        {
            Course us = _context.Courses.Find(id);
            _context.Courses.Remove(us);
            _context.SaveChanges();
            return RedirectToAction("ViewAdminCourses");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Course us = _context.Courses.Find(id);
            if (us == null)
            {
                return HttpNotFound();
            }
            return View(us);
        }

        [HttpPost]

        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(course).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("ViewAdminCourses");
            }
            return View(course);
        }
        public ActionResult ViewRegCourses()
        {
            return View(_context.CourseDetails.ToList());
        }
        public ActionResult ViewPayCourses()
        {
            return View(_context.PayDetails.ToList());
        }

    }
}