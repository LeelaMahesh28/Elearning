using System;
//using System.Text;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineLearning;

namespace OnlineTest
{
    [TestFixture]
    public class UserTest
    {

        [SetUp]
        public void TestUser()
        {
            Console.WriteLine("Executed before each testcase");
        }

        [TearDown]
        public void TestEnd()
        {
            Console.WriteLine("Executed after each testcase");
        }

        [Test]
        public void verification()
        {
            User bill = new User

            {
                Userid = 1,
                Username = "srii",
                Userpassword = "12345"
            };

            string actualResult = bill.User(1, "srii", "12345");
            Assert.AreEqual("srii", actualResult);
        }


        [TestCase(3, "Gv", "456")]
        public void TestUserdetails(int userid, string username, string userpassword)
        {
            User d = new User();
            string result = d.User(userid, username, userpassword);
            Assert.AreEqual("Diagnosis details", result);
        }

        [TestCase(1, "Gv", "456")]
        public void Testdetail(int userid, string username, string userpassword)
        {
            User detail = new User();
            string result = detail.User(userid, username, userpassword);
            Assert.AreEqual(("1,Gv,456"), result);
            Assert.AreNotEqual(("User details"), result);

        }

    }
}