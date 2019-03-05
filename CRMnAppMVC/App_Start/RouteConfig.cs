using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRMnAppMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Agenda-AgendaZilei",
            url: "{userID}/{controller}/{action}/{id}",
            defaults: new { userID = "100", controller = "Agenda", action = "AgendaZilei", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Agenda-AdaugaActiune",
            url: "{userID}/{controller}/{action}/{id}",
            defaults: new { userID = "100", controller = "Agenda", action = "GetSubActivitatiPartVw", numeActivitate = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Edit-Panels",
                url: "{userID}/{controller}/{action}/{id}/{panel}",
                defaults: new { userID = "100", controller = "Agenda", action = "AgendaZilei", id = UrlParameter.Optional, panel = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
