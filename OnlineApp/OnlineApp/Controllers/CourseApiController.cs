using Microsoft.Ajax.Utilities;
using OnlineApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineApp.Controllers
{
    public class CourseApiController : ApiController
    {
        UserContext db = new UserContext();
        //HttpGet is default
        //returns total course list
        [HttpGet]
        public IEnumerable<Course> GetCourseList()
        {
            return db.Courses.ToList();
        }
        //id taking course id as arg
        [HttpGet]
        public Course GetCourse(int id)
        {
            return db.Courses.Find(id);
        }
        //post method
        //will used to add course
        [HttpPost]
        public bool Course(Course c)
        {
            bool successflag = false;
            db.Courses.Add(c);
            db.SaveChanges();
            successflag = true;
            return successflag;
        }

    }
}

