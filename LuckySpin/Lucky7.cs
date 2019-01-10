using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin
{
    public class Lucky7
    {
        public string Output {
            get {
                Random random = new Random();
                int a = random.Next(1, 10);
                int b = random.Next(1, 10);
                int c = random.Next(1, 10);

                string output = 
                    "<button onclick='history.go(0)'>Spin</button>" +
                    "<div>" + a + "</div><div>" + b + "</div><div>" + c + "</div>" +
                    "<h1> Lucky Seven </h1>";
                if (a == 7 || b == 7 || c == 7)
                    output = output + 
                        "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>";


                return output;
            }
        }
    }
}
