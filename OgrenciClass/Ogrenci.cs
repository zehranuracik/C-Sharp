using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciClass
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vizeNotu;
        private int finalNotu;

        public Ogrenci(int no,string ad,string soyad, int vize, int final)
        {
            ogrenciNo = no;
            isim = ad;
            soyisim = soyad;
            vizeNotu = vize;
            finalNotu = final;    
        }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ogrenci Ismi = {isim}\nOgrenci Soyismi = {soyisim}\n" +
                $"Ogrenci No = {ogrenciNo}\nOgrenci Vize = {vizeNotu}\nOgrenci Final = {finalNotu}");
        }

        public double Ortalama()
        {
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }

    }
}
