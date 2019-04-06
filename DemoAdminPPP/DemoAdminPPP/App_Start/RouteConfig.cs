using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoAdminPPP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PPP", action = "Index", id = UrlParameter.Optional }
            );
            
            ////routes.MapRoute(
            ////    name: "Trangchu",
            ////    url: "{controller}/{action}",
            ////    defaults: new { controller = "PPP", action = "PPP/Index"}
            ////);
            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{name}/{pass}",
                defaults: new { controller = "Login", action = "../Index",name= UrlParameter.Optional , pass = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Dangnhap",
                url: "{controller}/{action}/{name}/{pass}",
                defaults: new { controller = "Login", action = "Index", name = UrlParameter.Optional, pass = UrlParameter.Optional }
            );
            //routes.MapRoute(
            //    name: "SanPham",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "PPP", action = "../SanPham" }
            //);
            //routes.MapRoute(
            //     name: "GangTay",
            //     url: "{controller}/{action}",
            //     defaults: new { controller = "PPP", action = "../GangTay" }
            // );

            routes.MapRoute(
                name: "Products",
                url: "{controller}/{action}",
                defaults: new { controller = "Products", action = "../Index" }
            );
            routes.MapRoute(
                name: "Users",
                url: "{controller}/{action}",
                defaults: new { controller = "Users", action = "../Index" }
            );
            routes.MapRoute(
                name: "Publisher",
                url: "{controller}/{action}",
                defaults: new { controller = "Publisher", action = "../Index" }
            );

        }
    }
}
