using _9_Polimorfizm.Alan_Hesabı;
using _9_Polimorfizm.Calısanlar;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kare kare = new Kare();
            //kare.Kenar = 5;
            //Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.KisaKenar = 5;
            //dikdortgen.UzunKenar = 15;



            //Console.WriteLine("Dikdortgen Alani:" + dikdortgen.Alan());

            //Console.WriteLine("Kare Alani:" + kare.Alan());
            //Daire daire = new Daire();
            //daire.YariCap = 5;
            //Console.WriteLine("Daire Alani:" + daire.Alan());


            Sekreter ayse = new Sekreter()
            {
                AdSoyad = "Ayse",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.Lise

            };

            Yazilimci ali = new Yazilimci()
            {
                AdSoyad = "Ali",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.YuksekLisans,
                Seviye = Seviye.Orta

            };

            ItMuduru fatma = new ItMuduru()
            {
                AdSoyad = "Fatma",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.Doktora,
                Performansi = Persormans.Iyi,
                Seviye = Seviye.Usta
            };


            Console.WriteLine("Sekreter  Maasi: " + ayse.MaasHesapla());
            Console.WriteLine("Orta Yazilimci  Maasi: " + ali.MaasHesapla());
            Console.WriteLine("Orta Yazilimci  Maasi: " + fatma.MaasHesapla());


        }
    }
}