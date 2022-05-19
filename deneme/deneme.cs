using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 20; i++)
            {
                if (i == 6)
                {
                    Console.WriteLine();
                }
                for (int j = 1; j <= 10; j++)
                {   
                    Console.Write($"{j}X{k}={i*j}       ");
                }
                k++;
                
                if (k == 11)
                {
                    Console.WriteLine();
                    k = 1;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
