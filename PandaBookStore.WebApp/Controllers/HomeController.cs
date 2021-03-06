﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PandaBookStore.WebApp.Models;
using PandaBookStore.Data;
using PandaBookStore.Data.Entities;
using PandaBookStore.Service;

namespace PandaBookStore.WebApp.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ICategoryService service)
        {
            //var result = repository.Table.ToList();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
