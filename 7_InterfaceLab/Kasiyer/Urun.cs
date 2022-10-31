using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public enum Birim
    {
        adet = 1,
        gram,
        mililitre
    }
    public class Urun
    {
        public string UrunAdi { get; set; }
        public Birim Birim { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
}
