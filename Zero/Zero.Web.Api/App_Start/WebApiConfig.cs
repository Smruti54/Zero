//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Http;
//using System.Web.Http.OData.Builder;
//using System.Web.Http.OData.Extensions;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.OData.Batch;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNet.OData.Routing.Conventions;

using Zero.model;
using Zero.Web.Api.App_Start;

namespace Zero.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            

            config.Routes.MapHttpRoute(name: "DefaultActionApi", routeTemplate: "api/{controller}/{action}/{id}", defaults: new { id = RouteParameter.Optional });
            config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
            config.AddODataQueryFilter();


            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");

           config.MapODataServiceRoute(
           routeName: "Odata-Zero",
           routePrefix: "Odata-Zero",
           model: builder.GetEdmModel());

            var container = AutoFacConfig.Register();
            var resolver = new AutofacWebApiDependencyResolver(container);
           
            config.DependencyResolver = resolver;


        }
    }
}
