using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_InterfaceLab.FaturaKesim
{
    public enum FaturaTipi 
    { 
        Alis = 1,
        Satis,
        Iade
    }
    internal class FaturaMaster
    {
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime KesimTarihi { get; set; }
        public int FaturaNo { get; set; }

        public FaturaTipi FaturaTipi { get; set; }
        public List<FaturaDetay> FaturaDetaylari { get; set; }  
    }
}
