using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public class Satıs : Isatıs
    {
        public FaturaMaster SatısYap(Personel personel, Urun urun, Müsteri Müsteri)
        {
            FaturaMaster faturaMaster = new FaturaMaster()
            {
                Personel = personel,
                Müsteri = Müsteri,
                FaturaTarihi = DateTime.Now,
                FaturaNo = 1,
                FaturaTipi = FaturaTipi.Satıs

            };

            return faturaMaster;
        }
    }
}
