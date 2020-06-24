using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineApp.Controllers;

namespace OnlineAppTest
{
    class CourseControllerTest
    {
        [TestMethod]
        public void ViewCourse()
        {
            // Arrange
            CourseController controller = new CourseController();
            // Act
            ViewResult result = controller.ViewCourse() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Pay(int? id)
        {
            // Arrange
            CourseController controller = new CourseController();
            // Act
            ViewResult result = controller.Pay(1) as ViewResult;
            // Assert
            Assert.AreEqual(" sucessfully Paid", result.ViewBag.Message);
        }

        [TestMethod]
        public void SelectCourse(int? id)
        {
            // Arrange
            CourseController controller = new CourseController();
            // Act
            ViewResult result = controller.SelectCourse(1) as ViewResult;
            // Assert
            Assert.AreNotEqual(" sucessfully Paid", result.ViewBag.Message);
        }

    }
}
