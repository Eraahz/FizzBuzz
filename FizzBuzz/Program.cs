using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alice, choisis un nombre pour Bob : ");
            var chosedNumber = int.Parse(Console.ReadLine());
            FizzBuzzGame.AliceGiveNumberToBob(chosedNumber);
        }
    }
}
