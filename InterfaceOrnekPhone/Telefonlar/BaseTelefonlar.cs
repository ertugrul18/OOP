using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnekPhone
{
    public enum IsletimSistemi
    {
        Android = 1,
        İOS
    }
    public class BaseTelefonlar
    {
        public string Marka { get; set; }
        public string Model { get; set; }     
        public string UretimYili { get; set; }
        public int Fiyat { get; set; }
        public string HafizaAlani { get; set; }
        public string Batarya { get; set; } 
        public IsletimSistemi  IsletimSistemi { get; set; }

        //public override string ToString()   // override kullandık base kısmında kullandık tek tek heryere yazmaya gerek yok diye 
        //{                                     // bunu yazma amacımız yazdığımız kodun çalışması isim olarak basması içn
        //    return Marka;
        //}
    }
}
