using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Library.Controllers;
using Library.Models;

namespace Library.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Home_ReturnsCorrect_View()
        {
            HomeController testController = new HomeController();
            ActionResult indexView = testController.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}
