//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineLearning;
using System;
//using System.Collections.Generic;
//using System.Text;
using TestApp;

namespace OnlineTest
{
    [TestFixture]
    public class AdminTest
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
                AdminLogin bill = new AdminLogin

                 {
                    Userid = 1,
                    Username = "srii",
                    Usercourse = "Azure",
                    Department="Cloud"
                };

                string actualResult = bill.AdminLogin(1, "srii", "Azure","Cloud");
                Assert.AreEqual("srii", actualResult);
           
        }
}