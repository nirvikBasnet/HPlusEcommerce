using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Filter
{
    //creating a actionfilter onactionexecuting
    public class LogRequestFilter : ActionFilterAttribute //extend this
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //creating a dynamic object
            var log = new
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                Ip = filterContext.HttpContext.Request.UserHostAddress,
                DateTime = filterContext.HttpContext.Timestamp
            };

            Debug.WriteLine(JsonConvert.SerializeObject(log));

           
        }

    }
}