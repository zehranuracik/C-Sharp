using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAylar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-12 Arasinda Bir Sayi Giriniz: ");
            int ay = int.Parse(Console.ReadLine());
            Aylar getAy = (Aylar)ay;
            Console.WriteLine($"{ay}.AY = {getAy}");
            Console.ReadKey();
            
        }
        enum Aylar
        {
            OCAK=1,SUBAT,MART,NISAN,MAYIS,HAZIRAN,TEMMUZ,AGUSTOS,EYLUL,EKIM,KASIM,ARALIK
        }
    }
}
