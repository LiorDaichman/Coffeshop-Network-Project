using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CoffeeShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomePage",
                url: "",
                defaults: new { controller = "HomePage", action = "ViewHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "HomePage2",
                url: "Home",
                defaults: new { controller = "HomePage", action = "ViewHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { controller = "HomePage", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "login",
                url: "login",
                defaults: new { controller = "HomePage", action = "Login", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "Menu",
                url: "Menu",
                defaults: new { controller = "HomePage", action = "Menu", id = UrlParameter.Optional }
            );







            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
