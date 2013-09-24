using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Store.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                null,
                "", // соответствует только пустому URL
                new { controller = "Product", action = "List" , category = (string)null, page = 1}
                );
            routes.MapRoute(
                null,
                "Page{page}", // соответствует /Page2, /Page123, но не /PageXYZ
                new { controller = "Product", action = "List", category = (string)null },
                new { page = @"\d+" } // ограничения: страница должна быть чистой
                );
            routes.MapRoute(
                null,
                "{category}", // соответствует /Мониторы
                new { controller = "Product", action = "List",  page = 1 }
                );
            routes.MapRoute(
                null,
                "{category}/Page{page}", // соответвтвует /Мониторы/Page567
                new { controller = "Product", action = "List" }, // по умолчанию
                new { page = @"\d+" } // ограничения: страница должна быть чистой
            );
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}