using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp.API;
using HelloWorldApp.API.Controllers;
using HelloWorldApp.Console.Services;

namespace HelloWorldApp.API.Test.Controller
{
    [TestClass]
    public class AppControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AppController controller = new AppController();
            IHelloWorldService _repository = new HelloWorldService();

            // Act
            ViewResult result = controller.Index() as ViewResult;
            var greeting = _repository.getGreetings(true);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
            Assert.AreEqual("Hello World", greeting);
        }
    }
}
