using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            int number2 = 25;
            if (number2 == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 20");
            }
            Console.ReadLine();
        }
    }
}
