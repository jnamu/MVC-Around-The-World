using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAroundTheWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Welcome",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AroundTheWorldController", action = "Welcome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tutorials",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AroundTheWorldController", action = "Tutorials", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tutorial1",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AroundTheWorldController", action = "Tutorial1", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tutorial2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AroundTheWorldController", action = "Tutorial2", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ScoreBoard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AroundTheWorldController", action = "ScoreBoard", id = UrlParameter.Optional }
            );


        }
    }
}
