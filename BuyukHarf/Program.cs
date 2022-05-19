using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Lutfen Kelimenizi Giriniz: ");
            string kelime = Console.ReadLine();
            List<int> listem = new List<int>();
            foreach (var i in kelime)
            {
                int kontrol = Convert.ToInt32(i);
                if (kontrol < 97)
                {
                    listem.Add(sayac);
                }
                sayac++;
            }
            Console.Write("Kelimedeki Sesli Harflerin Indisleri: ");
            foreach (var i in listem)
            {
                Console.Write(i + " ");
            }
            
            Console.ReadKey();


        }
    }
}
