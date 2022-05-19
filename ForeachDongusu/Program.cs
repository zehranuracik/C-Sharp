using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int[] Sayilar = { 12, 45, 78, 96, 23, 52, 41, 85, 45, 12, 69, 73 };
            Console.Write("Kontrol Etmek Istediginiz Sayiyi Girinzi: ");
            int a  = Convert.ToInt32(Console.ReadLine());
            foreach(int i in Sayilar)
            {
                if(i == a)
                {
                    sayac++;
                }
            }
            if (sayac == 0) Console.WriteLine("Girdiginiz Sayi Dizide Bulunmamaktadir.");
            else Console.WriteLine($"Girdiginiz Sayi Dizide {sayac} Kez Bulunmaktadir.");
            Console.ReadKey();
        }
    }
}
