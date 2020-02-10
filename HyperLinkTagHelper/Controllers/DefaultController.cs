﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace HyperLinkTagHelper.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendData(string data)
        {
            Console.WriteLine(data);
            return RedirectToAction("Index");
        }
    }
}