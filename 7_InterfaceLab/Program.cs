using System;
using _7_InterfaceLab.FirinOtomasyon;
using _7_InterfaceLab.Güvenlik;

namespace _7_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region FırınOtomasyon
            //Usta aliUsta = new Usta();
            //aliUsta.Isim = "Ali Yilmaz";

            //Urun un = new Urun();
            //un.Isim = "Beyaz Un";
            //un.Birim = Birim.Gram;
            //un.Mitar = 3000;
            //un.Fiyat = 1;

            //Urun tuz = new Urun();
            //tuz.Isim = "Kaya Tuzu";
            //tuz.Mitar = 200;
            //tuz.Birim = Birim.Gram;
            //tuz.Fiyat = 1;

            //Urun su = new Urun();
            //su.Isim = "Musluk Suyu";
            //su.Mitar = 200;
            //su.Fiyat = 1;
            //su.Birim = Birim.Mlitre;

            //List<Urun> urunler = new List<Urun>();
            //urunler.Add(un);
            //urunler.Add(su);
            //urunler.Add(tuz);

            //YogurmaMakinasi yogurmaMakinasi = new YogurmaMakinasi();
            //yogurmaMakinasi.MakinaAdi = "Bosh";

            //// IYogur yogurucu = new IYogur();  // bu şekilde olmaz

            //Firin karafirin = new Firin();

            ////karafirin.EkmekPisir(urunler, aliUsta);
            ////karafirin.EkmekPisir(urunler, yogurmaMakinasi);

            //karafirin.EkmekPisir(urunler, aliUsta);

            #endregion

            #region Guvenlik
            List<GirisKarti> girisKartlari = new List<GirisKarti>();

            GuvenlikGorevlisi BekciMurtaza = new GuvenlikGorevlisi();
            BekciMurtaza.Ad = "Murtaza";
            BekciMurtaza.Soyad = "Kaya";
            KimlikKarti ahmet = new KimlikKarti() {TcNo ="123" };
            KimlikKarti mehmet = new KimlikKarti() { TcNo = "456" };
            KimlikKarti ayse = new KimlikKarti() { TcNo = "789" };
            KimlikKarti fatma = new KimlikKarti() { TcNo = "abc" };

            GirisKarti girisKarti1 = BekciMurtaza.GirisKartiVer(ahmet);
            GirisKarti girisKarti2 = BekciMurtaza.GirisKartiVer(mehmet);
            GirisKarti girisKarti3 = BekciMurtaza.GirisKartiVer(ayse);
            GirisKarti girisKarti4 = BekciMurtaza.GirisKartiVer(fatma);
            girisKartlari.Add(girisKarti1);
            girisKartlari.Add(girisKarti2);
            girisKartlari.Add(girisKarti3);
            girisKartlari.Add(girisKarti4);

            BekciMurtaza.KimlikleriListele();
            Console.WriteLine("**** Kart Listele **** ");
            BekciMurtaza.KimlikKartiVer(girisKarti1);
            BekciMurtaza.KimlikleriListele();
            Console.WriteLine("**** Kart Listele ****");

            BekciMurtaza.KimlikKartiVer(girisKarti2);
            BekciMurtaza.KimlikleriListele();

            #endregion
        }
    }
}