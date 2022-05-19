using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftTekToplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ciftToplam = 0, tekToplam = 0;
            int[] Sayilar = new int[10];
            for (int i=0;i<Sayilar.Length;i++)
            {
                Console.Write($"Dizinin {i+1}. Degerini Giriniz: ");
                Sayilar[i]= int.Parse(Console.ReadLine());
            }
            foreach (int i in Sayilar)
            {
                if (i % 2 == 0) ciftToplam += i;
                else tekToplam += i;
            }
            Console.WriteLine("Cift Sayilarin Toplami = " + ciftToplam);
            Console.WriteLine("Tek Sayilarin Toplami = " + tekToplam);
            if (ciftToplam > tekToplam) Console.WriteLine("Cift Toplam > Tek Toplam");
            else if (ciftToplam < tekToplam) Console.WriteLine("Tek Toplam > Cift Toplam");
            else Console.WriteLine("Tek Toplam = Cift Toplam");
            Console.ReadKey();
        }
    }
}
