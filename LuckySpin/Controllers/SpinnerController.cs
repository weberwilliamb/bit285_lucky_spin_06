using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        /***
         * Entry Page Action
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            return RedirectToAction("SpinIt", player);
        }

        /***
         * Spin Action
         **/  
               
        Random random = new Random() ; 


        public IActionResult SpinIt(Player player)
        {
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            if (a == player.Luck || b == player.Luck || c == player.Luck)
                ViewBag.Display = "block";
            else
                ViewBag.Display = "none";

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.C = c;

            return View("SpinIt", player);
        }
    }
}

