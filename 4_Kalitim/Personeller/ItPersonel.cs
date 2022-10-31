using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Personeller
{
    internal class ItPersonel : BasePersonel  // BasePersonelden Kalıtım aldık Inheritance kullandık.
    {
        //Aşağıdaki gibi yazıyorduk her departman için sonrasında kod tekrarı olduğu için bunları kalıtım aldık (inheritance).
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public string TcNo { get; set; }
        //public bool Cinsiyet { get; set; }

        public void TeknikDestek()
        {

        }
       
    }
}
