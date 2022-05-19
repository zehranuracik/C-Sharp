using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("Renault", "Kirmizi", 4);

            Console.WriteLine("Araba Rengi = "+araba1.arabaRenk);
            Console.WriteLine("Araba Modeli = "+araba1.arabaModel);
            Console.WriteLine("Araba Kapi Sayisi = " + araba1.kapiSayisi);

            araba1.motorCalistir();
            araba1.kapilariKilitle();

            Console.ReadKey();
        }
    }
}
