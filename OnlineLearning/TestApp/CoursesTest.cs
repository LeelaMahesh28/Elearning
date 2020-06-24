using System;
//using System.Text;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineLearning;

namespace TestApp
{
    [TestFixture]
    public class UserTest
    {

        [SetUp]
        public void TestCourses()
        {
            Console.WriteLine("Executed before each testcase");
        }

        [TearDown]
        public void TestEnd()
        {
            Console.WriteLine("Executed after each testcase");
        }

        [Test]
        public void Courses1()
        {
            Courses cou = new Courses

            {
                Courseid = 101,
                Coursename = "Azure",
                Coursedepartment = "Cloud",
                professorname = "Ravi"
            };

            string actualResult = cou.Courses(101, "Azure", "Cloud", "Ravi");
            Assert.AreEqual("Azure", actualResult);
        }


        [TestCase(301,"DS","C","Geetha")]
        public void TestCoursedetails(int courseid, string coursename, string coursedepartment, string professorname)
        {
            Courses d = new Courses();
            string result = d.Courses(courseid, coursename, coursedepartment, professorname);
            Assert.AreEqual("Courses details", result);
        }

        [TestCase(101, "DS", "C", "Geetha")]
        public void TestCdetail(int courseid, string coursename, string coursedepartment, string professorname)
        {
            Courses det = new Courses();
            string result = det.Courses(courseid, coursename, coursedepartment, professorname);
            Assert.AreEqual(("101,DS,C,Geetha"), result);
            Assert.AreNotEqual(("Course details"), result);

        }

    }
}
