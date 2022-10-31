using System;
using System.Collections.Generic;
using System.Text;

namespace Kasa
{
    public interface Isatıs
    {
        FaturaMaster SatısYap(Personel personel, Urun urun, Müsteri Müsteri);
    }
}
