﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}