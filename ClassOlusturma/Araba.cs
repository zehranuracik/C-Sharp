using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    public class Araba
    {
        public string arabaModel;
        public string arabaRenk;
        public int kapiSayisi;

        public Araba(string _arabaModel, string _arabaRenk, int _kapiSayisi)
        {
            arabaModel = _arabaModel;
            arabaRenk = _arabaRenk;
            kapiSayisi = _kapiSayisi;
        }
        public void motorCalistir()
        {
            Console.WriteLine("Motor Calistiriliyor...");
        }
        public void kapilariKilitle()
        {
            Console.WriteLine("Kapilar Kilitleniyor...");
        }
    }
}
