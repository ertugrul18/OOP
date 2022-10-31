using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Interface
{
    public class BaseFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public byte FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Agresiflik { get; set; }
        public byte Refleks { get; set; }
        public bool Milli { get; set; }
        public override string ToString()   // override kullandık base kısmında kullandık tek tek heryere yazmaya gerek yok diye 
        {                                     // bunu yazma amacımız yazdığımız kodun çalışması isim olarak basması içn
            return AdiSoyadi;
        }
    }
}
