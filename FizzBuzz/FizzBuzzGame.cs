using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static object AliceGiveNumberToBob(int number)
        {
            if (number == 0)
            {
                throw new ArgumentException();
            } 
            else if (number < 0) 
            {
                throw new ArgumentException();
            } 
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number;
            }
        }
    }
}
