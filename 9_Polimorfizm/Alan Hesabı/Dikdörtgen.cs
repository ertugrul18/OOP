using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Alan_Hesabı
{
   
        internal class Dikdortgen : AlanveCevre
        {
            public int KisaKenar { get; set; }
            public int UzunKenar { get; set; }

            public override double Alan()
            {
                return KisaKenar * UzunKenar;
            }
            public override double Cevre()
            {
                return (KisaKenar + UzunKenar) * 2;
            }
        }
    
}
