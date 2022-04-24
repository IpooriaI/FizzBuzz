using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logic
{
    public class Game
    {
        public string DivideBy3And5(int number)
        {
            var dividedBy3 = number % 3;
            var dividedBy5 = number % 5;
            if (dividedBy3 == 0 && dividedBy5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                return "";
            }
        }

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

        public string DivideBy5(int number)
        {
            var answear = number % 5;
            if (answear == 0)
            {
                return "Buzz";
            }
            else
            {
                return "";
            }
        }


    }
}
