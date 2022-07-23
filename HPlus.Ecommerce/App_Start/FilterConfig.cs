using HPlus.Ecommerce.Filter;
using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //nirvik, need to add all filter here if you want to make them global
            filters.Add(new LogRequestFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
