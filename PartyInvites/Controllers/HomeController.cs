﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RspvForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RspvForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestresponse);
            }
            else
            {
                return View();
            }
        }

    }
}