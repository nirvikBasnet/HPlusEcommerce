using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //using attribute routing to get detail of specific product
        //nirvik, for reference , Constraint Value [Route("product/{produceId:int?})], should be int or null
        //Custom Constrains, Should register in RouteConfig.cs
        //nirvik, I am using product name for SEO
        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            //get ther product detail from the db 
            return View();
        }
    }
}