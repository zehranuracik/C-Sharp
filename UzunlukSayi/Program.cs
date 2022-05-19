using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzunlukSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen Sayiyi Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("Lutfen Uzunlugu Giriniz: ");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] dizim = new int[uzunluk];
            for (int i = 0; i < dizim.Length; i++)
            {
                dizim[i] = Hesapla(sayi, i + 1);
            }
            foreach (int i in dizim) Console.Write(i+" ");
            Console.ReadKey();
        }
        static int Hesapla(int num, int a)
        {
            return num * a;
        }
    }
}
