namespace _11_EventAraba
{
    public delegate void EventTip(int a, object sender);
    internal class Program
    {


        static void Main(string[] args)
        {
            Surucu surucu = new Surucu(" Ertuğrul");
            Polis polis = new Polis(" Mehmet Kaya");
            Araba araba = new Araba("41 ACU 505", 180);
            araba.HareketEdiyorum += polis.HizKontrolEt;
            surucu.GazaBastim += araba.Calis;
            surucu.GazaBas();
            Console.ReadLine();

        }


    }
}