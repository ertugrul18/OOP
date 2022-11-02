namespace _11_EventBomba
{
    internal class Telefon
    {
        public event Eventtip KelimeKullanildi;
        public Telefon()
        {
        }

        public void Gorusme()
        {
            Console.WriteLine("Aloo ..");
            string input = Console.ReadLine();

            if (input.Contains("AliVeli4950"))
            {
                KelimeKullanildi();
            }
            else if (input == "Kapat")
            {
                return;
            }
            Gorusme();
        }
    }
}