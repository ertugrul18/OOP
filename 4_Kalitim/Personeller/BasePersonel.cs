using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Personeller
{
    public class BasePersonel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public bool Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; } // Buraya eklediğim için diğer inheritance veridiğim yerlerede yansımış oldu.
        
        public void IseZamanindaGel()   // Buraya eklediğim için diğer inheritance veridiğim yerlerede yansımış oldu.
        {

        }

    }
}
