using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CoffeShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomePage",
                url: "",
                defaults: new { controller = "HomePage", action = "HomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "HomePage1",
                url: "HomePage",
                defaults: new { controller = "HomePage", action = "HomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Registry",
                url: "Registry",
                defaults: new { controller = "Customer", action = "Enter", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Registry1",
                url: "Submit",
                defaults: new { controller = "Customer", action = "Submit", id = UrlParameter.Optional }
            );
        }
    }
}
