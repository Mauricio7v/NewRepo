﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}