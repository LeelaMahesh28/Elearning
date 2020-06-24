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
    class AdminControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AdminController controller = new AdminController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Login()
        {
            // Arrange
            AdminController controller = new AdminController();
            // Act
            ViewResult result = controller.Login() as ViewResult;
            // Assert
            Assert.AreEqual("Welcome Admin", result.ViewBag.Message);
        }

        [TestMethod]
        public void LoggedIn()
        {
            // Arrange
            AdminController controller = new AdminController();
            // Act
            ViewResult result = controller.LoggedIn() as ViewResult;
            // Assert
            Assert.AreNotEqual("Welcome Admin", result.ViewBag.Message);
        }


    }
}
