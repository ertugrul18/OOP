using _9_Polimorfizm.Alan_Hesabı;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
            kare.Kenar = 5;
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 5;
            dikdortgen.UzunKenar = 15;



            Console.WriteLine("Dikdortgen Alani:" + dikdortgen.Alan());

            Console.WriteLine("Kare Alani:" + kare.Alan());
            Daire daire = new Daire();
            daire.YariCap = 5;
            Console.WriteLine("Daire Alani:" + daire.Alan());


        }
    }
}