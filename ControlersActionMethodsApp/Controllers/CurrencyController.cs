using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControlersActionMethodsApp.Models;

namespace ControlersActionMethodsApp.Controllers
{
    public class CurrencyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult BTC()
        {
            return View();
        }


        public IActionResult ETH()
        {
            return View();
        }
        


    }
}




