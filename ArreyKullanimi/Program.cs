using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students1 = new string[] { "Zehra", "Emin", "Hasan" };
            string[] students2 = new string[3];
            students2[0] = "Ayse";
            students2[1] = "Mehmet";
            students2[2] = "Ahmet";

            Console.WriteLine(students1[2]);
            Console.WriteLine(students2[1]);

            Console.ReadKey();
        }
    }
}
