using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public enum FaturaTipi
    {
        Alıs = 1,
        Satıs,
        İade

    }
    public class FaturaMaster
    {
        public Personel Personel { get; set; }
        public Müsteri Müsteri { get; set; }
        public int FaturaNo { get; set; }
        public FaturaTipi FaturaTipi { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public List<FaturaDetay> FaturaDetaylar { get; set; }

    }
}
