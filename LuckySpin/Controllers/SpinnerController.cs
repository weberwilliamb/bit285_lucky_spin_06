using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        public IActionResult Index()
        {
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            if (a == 7 || b == 7 || c == 7)
                ViewBag.image = "block";
            else
                ViewBag.image = "none";


            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;


            return View();
        }
    }
}