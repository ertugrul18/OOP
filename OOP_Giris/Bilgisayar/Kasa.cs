using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.Bilgisayar
{
    public class Kasa
    {
        public CPU Cpu { get; set; }
        public AnaKart AnaKart { get; set; }
        public Ram Ram { get; set; }
        public  HDD HDD { get; set; }
        public SSD SSD { get; set; }    


    }
}
