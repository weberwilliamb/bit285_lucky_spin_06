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
        private Repository repository;
        Random random = new Random();

        /***
         * Controller Constructor
         */
        public SpinnerController(Repository r)
        {
            repository = r;
        }

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
            if(ModelState.IsValid)
                return RedirectToAction("SpinIt", player);
            return View();
        }

        /***
         * Spin Action
         **/  
               
         public IActionResult SpinIt(Player player)
        {
            Spin spin = new Spin
            {
                Luck = player.Luck,
                A = random.Next(1, 10),
                B = random.Next(1, 10),
                C = random.Next(1, 10)
            };

            spin.IsWinning = (spin.A == spin.Luck || spin.B == spin.Luck || spin.C == spin.Luck);

            //Add to Spin Repository
            repository.AddSpin(spin);

            //Prepare the View
            if(spin.IsWinning)
                ViewBag.Display = "block";
            else
                ViewBag.Display = "none";

            ViewBag.FirstName = player.FirstName;

            return View("SpinIt", spin);
        }

        /***
         * ListSpins Action
         **/

         public IActionResult LuckList()
        {
                return View(repository.PlayerSpins);
        }

    }
}

