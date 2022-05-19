using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalisma
{
    internal class Icecek
    {
        private double ucret = 0;
        public List<string> icerik = new List<string>();
        public void IcerikGoster()
        {
            Console.WriteLine("Iceceginizin Icerigi: ");
            foreach (var i in icerik)
            {
                Console.Write(i + " ");
            }
        }
        public void UcretGoster()
        {
            int a = icerik.Count();
            ucret = a * 1.5;

            Console.WriteLine("Toplam Ucret: " + ucret+"£");
        }
        public void IcecekAdi()
        {
            Console.Write("Iceceginizin Adi: ");
            foreach(var i in icerik)
            {
                Console.Write(i+" ");
            }
            if(icerik.Count() == 1)
            {
                Console.WriteLine("Smoothie");
            }
            else Console.WriteLine("Fusion");
        }
    }
}
