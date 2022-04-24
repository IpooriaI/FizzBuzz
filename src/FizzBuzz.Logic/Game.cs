using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logic
{
    public class Game
    {
        public string DivideBy3(int number)
        {
            var answear = number % 3;
            if(answear==0)
            {
                return "Fizz";
            }
            else
            {
                return "";
            }
        }


    }
}
