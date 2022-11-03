using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyon.Entities
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }

        public List<Extra> Extralar { get; set; }

        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;
            switch (Boyut)
            {

                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.1m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.2m;
                    break;
                default:
                    break;
            }
            foreach (Extra extra in Extralar)
            {
                ToplamTutar += extra.ExtraFiyati;

            }
            ToplamTutar = ToplamTutar * Adet;
        }

    }
}
