using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Futbol
{
    public class Kaleci : BaseOzellik, IPasVerebilir, ISutCekebilir, IGolAtabilir, ITopaElleDokunabilir
    {
        public void GolAtabilir()
        {
            throw new NotImplementedException();
        }

        public void PasVerebilir()
        {
            throw new NotImplementedException();
        }

        public void SutCekebilir()
        {
            throw new NotImplementedException();
        }

        public void TopaElleDokunabilir()
        {
            throw new NotImplementedException();
        }
    }
}
