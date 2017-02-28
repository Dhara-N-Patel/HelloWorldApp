using System.Web.Mvc;

namespace HelloWorldApp.API.AppConfiguration
{
    public class FilterConfiguration
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}