using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum KoltukEbat
    {
       ÜçlüKoltuk = 1,
       IkiliKoltuk,
       Teklikoltuk

    }
    public class KoltukTakimi
    {
                
            public string Marka { get; set; }
            public string Model { get; set; }
            public KoltukEbat  KoltukEbat { get; set; }
            public string Renk { get; set; }
            public string Kumas { get; set; }
    }
}
