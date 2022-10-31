using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public class FaturaDetay
    {
        public int FaturaDetayId { get; set; }
        public int FaturaNo { get; set; }
        public decimal Fiyat { get; set; }
        public decimal İndirimOranı { get; set; }
        public Urun Urun { get; set; }
        public int Miktar { get; set; }
        
    }
}
