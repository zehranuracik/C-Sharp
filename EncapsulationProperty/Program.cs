using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.KILO = 85;   // Değer ataması yapılırsa set bloğu çalışır.
            Console.WriteLine("Ogrencinin Kilosu: "+ogrenci1.KILO);  // Değer atanmazsa get bloğu çalışır.
            Console.ReadKey();
        }
    }
}
