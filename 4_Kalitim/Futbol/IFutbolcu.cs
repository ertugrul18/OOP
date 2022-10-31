using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Futbol
{
    public interface IFutbolcu  // Tek Tek tüm özellikleri class olarak açtık ama futbolcu diyerek bu şekilde interface yaparak tüm özelliklerini de ınterface yazabiliriz.
    {
        public void PasVerebilir();
        public void SutCekebilir();
        public void GolAtabilir();
        public void Kosabilir();

    }
}
