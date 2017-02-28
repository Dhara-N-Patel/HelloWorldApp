using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HelloWorldApp.API.AppConfiguration;

namespace HelloWorldApp.API
{
    public class WebAPIApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebAPIConfiguration.Register);
            FilterConfiguration.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfiguration.RegisterRoutes(RouteTable.Routes);
            BundleConfiguration.RegisterBundles(BundleTable.Bundles);
        }
    }
}
