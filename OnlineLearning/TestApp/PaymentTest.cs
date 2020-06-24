using System;
//using System.Text;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineLearning;

namespace TestApp
{
    [TestFixture]
    public class PaymentTest
    {

        [SetUp]
        public void TestPayment()
        {
            Console.WriteLine("Executed before each testcase");
        }

        [TearDown]
        public void TestEnd()
        {
            Console.WriteLine("Executed after each testcase");
        }

        [Test]
        public void Payment1()
        {
            Payment pay = new Payment

            {
                Cid = 101,
                TotAmnt = "400",
                
            };

            string actualResult = pay.Payment(101,"400");
            Assert.AreEqual("400", actualResult);
        }


        [TestCase(301, "300")]
        public void TestPay(int cid, string totamnt)
        {
            Payment d = new Payment();
            string result = d.Payment(101,"400");
            Assert.AreEqual("Pay details", result);
        }

        [TestCase(301, "350")]
        public void TestPdetail(int cid, string totamnt)
        {
            Payment det = new Payment();
            string result = det.Payment(cid,totamnt);
            Assert.AreEqual(("301,350"), result);
            Assert.AreNotEqual(("Pay details"), result);

        }

    }
}
