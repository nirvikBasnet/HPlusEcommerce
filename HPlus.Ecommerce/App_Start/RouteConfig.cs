using System.Web.Mvc;
using System.Web.Routing;

namespace HPlus.Ecommerce
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //to use attributes for routing      

            routes.MapMvcAttributeRoutes();


            //if we only want attribute routing need to remove below
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
