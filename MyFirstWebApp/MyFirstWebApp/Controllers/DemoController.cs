﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewData["Name"] = "陳小強";
            return View();
        }

        // GET: Demo/ShowHelloWorld
        public string ShowHelloWorld()
        {
            return "Hello World!";
        }

        [HttpGet]//可省略
        public string ShowPrice(string product, int price)
        {
            return $"商品是:{product}，價格是{price}";
        }
    }
}