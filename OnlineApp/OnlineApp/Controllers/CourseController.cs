using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineApp.Migrations;
using OnlineApp.Models;

namespace OnlineApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        
        private UserContext _context;
        public CourseController()
        {
            this._context = new UserContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ViewCourse()
        {
            return View(_context.Courses.ToList());
        }
        
        public ActionResult SelectCourse(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Course course = _context.Courses.Find(id);
            if(course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }
        

        [HttpPost]
        public ActionResult SelectCourse(Course course)
        {
            
            if (ModelState.IsValid)
            {
                using (UserContext db = new UserContext())
                {
                    
                    CourseDetails cod = new CourseDetails();
                    cod.UsId = Convert.ToInt16(Session["UserId"]);
                    cod.CoId = course.CourseId;
                    cod.CoName = course.CourseName;
                    cod.CoDept = course.CourseDept;
                    db.CourseDetails.Add(cod);
                    db.SaveChanges();
                    ViewBag.Message = " sucessfully registered";
                }
 
                ModelState.Clear();
                
            }
            
            return View(course);
        }
        
        public ActionResult Pay(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Course course = _context.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.Message = " sucessfully Paid";
            return View(course);
        }
        public ActionResult SchedDate(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Course course = _context.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }
        [HttpPost]
        public ActionResult SchedDate(Course course,string ScheduleDate)
        {

            if (ModelState.IsValid)
            {
                using (UserContext db = new UserContext())
                {
                    DateTime Val = Convert.ToDateTime(ScheduleDate);
                    PayDetail pd = new PayDetail();
                    pd.Uid = Convert.ToInt16(Session["UserId"]);
                    pd.Cid = course.CourseId;
                    pd.Status= "Paid";
                    pd.ScheduleDate=Val; 
                    db.PayDetails.Add(pd);
                    db.SaveChanges();
                    ViewBag.Message = " sucessfully Scheduled";
                }

                ModelState.Clear();

            }
            return View();
        }
        public ActionResult ViewUrCourse()
        {
            using (UserContext db = new UserContext())
            {
                int id = Convert.ToInt16(Session["UserId"]);
                var crs = db.CourseDetails.SingleOrDefault(u => u.UsId == id );
                if (crs != null)
                {
                    return View();

                }
                else
                {
                    ModelState.AddModelError("", "No registered Courses.");
                }
            }
            return View();
        }

    }
    }
