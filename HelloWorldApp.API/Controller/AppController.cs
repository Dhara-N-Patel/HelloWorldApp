using HelloWorldApp.Console.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldApp.API.Controllers
{
    public class AppController : Controller
    {
        private IHelloWorldService _repository;

        public AppController()
        {
            _repository = CreateGreetingRepository();
        }

        protected virtual IHelloWorldService CreateGreetingRepository()
        {
            // Inject dependency.
            return new HelloWorldService();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult getGreetings()
        {
            var fromAPI = true;
            var greeting = _repository.getGreetings(fromAPI);

            return Json(greeting, JsonRequestBehavior.AllowGet);
        }
    }
}
