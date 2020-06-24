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
    class UserControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            UserController controller = new UserController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Login()
        {
            // Arrange
            UserController controller = new UserController();
            // Act
            ViewResult result = controller.Login() as ViewResult;
            // Assert
            Assert.AreEqual("Welcome User", result.ViewBag.Message);
        }

        [TestMethod]
        public void LoggedIn()
        {
            // Arrange
            UserController controller = new UserController();
            // Act
            ViewResult result = controller.LoggedIn() as ViewResult;
            // Assert
            Assert.AreNotEqual("Welcome User", result.ViewBag.Message);
        }

    }
}
