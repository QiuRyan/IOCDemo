using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApiContrib.Formatting.Jsonp;

namespace WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            JsonMediaTypeFormatter formatter = new JsonMediaTypeFormatter
            {
                SerializerSettings =
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DateFormatString = "G",
                    DefaultValueHandling = DefaultValueHandling.Populate,
                    Formatting = Formatting.None,
                    NullValueHandling = NullValueHandling.Include
                }
            };
            // Web API 配置和服务
            config.Formatters.Remove(config.Formatters.JsonFormatter);
            config.Formatters.Insert(0, formatter);
            config.AddJsonpFormatter(formatter);
            config.Formatters.Add(new BsonMediaTypeFormatter());

            // Web API 路由
            config.MapHttpAttributeRoutes();
            AutofacConfig.Register();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}