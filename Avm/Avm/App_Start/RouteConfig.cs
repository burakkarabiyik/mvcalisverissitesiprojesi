using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Avm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Anasayfa",
               url: "Anasayfa",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "alinacaklar",
               url: "order",
               defaults: new { controller = "Home", action = "alinacaklar", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Hakkimizda",
               url: "Hakkimizda",
               defaults: new { controller = "Home", action = "Hakkimizda", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "iletisim",
               url: "iletisim",
               defaults: new { controller = "Home", action = "iletisim", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Register",
               url: "Register",
               defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Login",
              url: "Login",
              defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "Manage",
              url: "Manage",
              defaults: new { controller = "Manage", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
