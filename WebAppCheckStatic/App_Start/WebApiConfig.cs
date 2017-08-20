using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Common;
using Microsoft.Practices.Unity;
using WebAppCheckStatic.App_Start;

namespace WebAppCheckStatic
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      var container = new UnityContainer();
      container.RegisterType<ILogger, SuperLogger>(new ContainerControlledLifetimeManager());
      config.DependencyResolver = new UnityResolver(container);
      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
