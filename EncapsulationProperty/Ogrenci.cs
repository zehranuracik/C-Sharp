using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    public class Ogrenci
    {
        private int kilo;
        public int KILO
        {
            get { return kilo; }
            set { kilo = value; }
        }

        public int yas; // değişken 
        public int Yas { get; set; } // prop
        
        // yas ve Yas aynı şey. Eğer prop un geter ve seter blokları açılmadıysa nırmal bir değişken gibi davranır.

    }
}
