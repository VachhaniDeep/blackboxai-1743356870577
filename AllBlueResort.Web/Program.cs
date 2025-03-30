using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AllBlueResort.Web.App_Start;

namespace AllBlueResort.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Initialize MVC components
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize database and authentication
            DatabaseConfig.Initialize();
            
            // Configure AutoMapper if needed
            // MapperConfig.Configure();
        }

        protected void Application_BeginRequest()
        {
            // Security enhancements
            if (!Context.Request.IsSecureConnection && !Context.Request.IsLocal)
            {
                Response.Redirect(Context.Request.Url.ToString()
                    .Replace("http:", "https:"));
            }
        }
    }
}