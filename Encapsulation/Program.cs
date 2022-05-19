using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            Console.Write("Lutfen Ogrencinin Adini Giriniz: ");
            string ad = Console.ReadLine();
            ogrenci1.setIsim(ad);
            Console.WriteLine("Ogrencinin ismi = " + ogrenci1.getIsim());
            Console.ReadKey();
        }
    }
}
