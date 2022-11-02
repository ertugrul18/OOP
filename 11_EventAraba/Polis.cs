namespace _11_EventAraba
{
    internal class Polis : Insan
    {
        public Polis(string ad) : base(ad)
        {

        }
        public void HizKontrolEt(int hiz, object tetikleyen)
        {
            if (tetikleyen is Araba)
            {
                if (hiz > 120)
                {
                    Araba araba = (Araba)tetikleyen;
                    araba.AracCalısıyormu = false;
                    Console.WriteLine($"{araba.Plaka} plakalı aracin {araba.surucu.Ad} isimli sürücüye\n{hiz} km hızla gittiğinden dolayı {Ad} isimli polis tarafından ceza kesilmiştir...");
                }

            }
        }
    }
}