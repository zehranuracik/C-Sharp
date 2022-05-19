using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            string kullanici_adi = "zehranuracik", parola = "1234", username, pw;
            while (hak > 0)
            {
                Console.Write("Kullanici Adinizi Giriniz: ");
                username = Console.ReadLine();
                Console.Write("Parolanizi Giriniz: ");
                pw = Console.ReadLine();
                if (username == kullanici_adi && pw == parola)
                {
                    Console.WriteLine("HOSGELDİNİZ");
                    break;
                }
                else if (username == kullanici_adi && pw != parola)
                {
                    Console.WriteLine("Parola Hatali,Tekrar Deneyiniz");
                }
                else if (pw == parola && username != kullanici_adi)
                {
                    Console.WriteLine("Kullanici Adi Hatali,Tekrar Deneyiniz");
                }
                else Console.WriteLine("Kullanici Adi ve Parola Hatali,Tekrar Deneyiniz");
                hak--;
                if (hak == 0) Console.WriteLine("Hatali Giris Hakkinizi Doldurdunuz,Hoscakalin");
                else Console.WriteLine("Kalan Giris Hakki = " + hak);
            }
            Console.ReadKey();
        }
    }
}
