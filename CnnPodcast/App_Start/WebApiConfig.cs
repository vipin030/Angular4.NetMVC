using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CnnPodcast.Site
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Register(config.Routes);

            var jSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings = jSettings;
            GlobalConfiguration.Configuration.Formatters.Remove(config.Formatters.XmlFormatter);
        }

        public static void Register(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );
        }

    }
}