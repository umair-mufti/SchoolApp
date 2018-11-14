using SchoolApp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SchoolApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            StructuremapWebApi.Start();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
