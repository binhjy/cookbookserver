using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Web_Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // cái này có li
            var cors = new EnableCorsAttribute("http://cookbookweb-32.apphb.com", "*", "*");
            config.EnableCors(cors);

            //config.EnableCors(new EnableCorsAttribute("http://localhost:1188", "*", "*"));

            config.Routes.MapHttpRoute(
               name: "ActionApi",
               routeTemplate: "api/{controller}/{action}/{id}"
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));//đoạn cũ nó chỉ enable cho cái côkbôkweb thôi
            //mình enable cho all ukm, cũng éo hiểu lắm :v 
            // là * hả
            //pro vl 
            // mấy thánh sửa code dã man vl
            // đọc làm theo chứ éo hiểu đang làm cái gì hết
            // ủa sao t k thấy nó chỉ sửa đoạn này


        }
    }
}
