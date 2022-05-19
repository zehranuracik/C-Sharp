using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15, b = 20, c = 30;
            Selamla();
            Console.WriteLine("{0} + {1} = {2}", a, b, Ekle(a, b));
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, Ekle(a, b, c));

            Console.ReadKey();
        }
        static void Selamla()
        {
            Console.WriteLine("Hosgeldiniz");
        }
        static int Ekle(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Ekle(int number1, int number2, int number3) // overloading
        {
            return number1 + number2 + number3;
        }
    }
}
