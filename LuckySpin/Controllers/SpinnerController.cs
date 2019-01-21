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
            Spin spin = new Spin();
            spin.Luck = player.Luck;
            spin.A = random.Next(1, 10);
            spin.B = random.Next(1, 10);
            spin.C = random.Next(1, 10);

            if (spin.A == spin.Luck ||spin.B == spin.Luck || spin.C == spin.Luck)
                spin.Display = "block";
            else
                spin.Display = "none";

            ViewBag.FirstName = player.FirstName;

            return View("SpinIt", spin);
        }
    }
}

