﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_WebApiIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string UserName, string Ticket)
        {
            ViewBag.UserName = UserName;
            ViewBag.Ticket = Ticket;
            return View();
        }
    }
}
