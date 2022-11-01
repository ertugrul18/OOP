using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public enum Kimden
    {
        Emlakci = 1,
        Sahibinden

    }
    public class BaseEmlak
    {
        public string AdSoyad { get; set; }
        public int MetreKare { get; set; }
        public int KatSayisi { get; set; }
        public bool Esyalimi { get; set; }
        public bool Sitemi { get; set; }
        public bool AraKat { get; set; }
        public Kimden kimden { get; set; }

        int aidat = 100;
        double komisyon = 0;
        private double _Kira = 2500;

        public double Kira
        {
            get { return _Kira; }
            set { _Kira = value; }
        }


        public virtual double KiraHesapla()
        {
            if (KatSayisi >= 1)
            {
                Kira += 500;
            }
            if (MetreKare > 100)
            {
                Kira += MetreKare * 50;
            }
            if (Esyalimi)
            {
                Kira += 1000;
            }
            if (Sitemi)
            {
                Kira += aidat;
                Kira += 2000;
            }
            if (kimden == Kimden.Emlakci)
            {
                komisyon = ((Kira * 12) * 0.1);
            }

            return Kira;
        }


        public override string ToString()
        {
            return AdSoyad + " \n" + MetreKare + "\n" + KatSayisi + "\n" + "Eşyalımı: " + Esyalimi + "\nSitemi " + Sitemi + "\n" + "Kimden :" + kimden + "\nKira :" + Kira;
        }
    }

}
