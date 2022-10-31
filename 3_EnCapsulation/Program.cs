using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _3_EnCapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel ali = new Personel();
            ali.Ad = "Ali";
            ali.Soyad = "Yilmaz";
            string donendeger = ali.SetTcNo("a1234567891");
            Console.WriteLine(donendeger);
            Personel ayse = new Personel()
            {
                Ad = "Ayse",
                Soyad = "Kaya"

            };

            Personel2 fatma = new Personel2();
            fatma.TcNo = "12345678901";
            Console.WriteLine(fatma.TcNo);


            Insan ali = new Insan("ali","yilmaz");
        }

    }
}
