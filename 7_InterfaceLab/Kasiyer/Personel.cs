using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public class Personel :Isatıs
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }

        public void SatısYap()
        {
            throw new NotImplementedException();
        }

        public FaturaMaster SatısYap(Personel personel, Urun urun, Müsteri Müsteri)
        {
            throw new NotImplementedException();
        }
    }
}
