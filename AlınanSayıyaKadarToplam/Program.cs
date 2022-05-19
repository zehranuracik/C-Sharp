using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlınanSayıyaKadarToplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Lutfen Bir Sayi Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Sayilarin Toplami = " + toplam);
            if (toplam / sayi > 50) Console.WriteLine("Bolum 50 den Buyuktur.");
            else if (toplam / sayi < 50) Console.WriteLine("Bolum 50 den Kucuktur.");
            else Console.WriteLine("Bolum 50 ye Esittir.");
            Console.ReadKey();
        }
    }
}
