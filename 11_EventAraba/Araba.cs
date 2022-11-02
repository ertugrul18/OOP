namespace _11_EventAraba
{
    internal class Araba
    {
        private int maxHiz;

        public event EventTip HareketEdiyorum;
        public Araba(string plaka, int maxHiz)
        {
            Plaka = plaka;
            this.maxHiz = maxHiz;
        }

        public Surucu surucu { get; set; }
        public string Plaka { get; private set; }
        public bool AracCalısıyormu { get; set; }
        public void Calis(int gazOranı, object gazaBasan)
        {
            surucu = (Surucu)gazaBasan;
            int hiz = HizHesapla(gazOranı);
            AracCalısıyormu = true;
            Console.WriteLine($"Araba {hiz} km Hızla Gidiyor..! ");
            while (AracCalısıyormu)
            {
                HareketEdiyorum(hiz, this);
            }
        }

        private int HizHesapla(int gazOranı)
        {
            return maxHiz * gazOranı / 100;
        }
    }
}