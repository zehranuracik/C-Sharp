using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "5";
            string b = "6";
            Console.WriteLine(a + b);

            int sayi1 = int.Parse(a);
            int sayi2 = int.Parse(b);
            Console.WriteLine(sayi1 + sayi2);

            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            Console.WriteLine(num1 + num2);

            int c = 5;
            int d = 10;
            Console.WriteLine(c + d);

            string x = c.ToString();
            string y = d.ToString();
            Console.WriteLine(x + y);


            Console.ReadKey();
        }
    }
}
