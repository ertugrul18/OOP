namespace _11_EventAraba
{
    internal class Surucu : Insan
    {
        public event EventTip GazaBastim;
        public Surucu(string ad) : base(ad)
        {

        }

     

        public void GazaBas()
        {
            Random rnd = new Random();
            int GazOranı = rnd.Next(100, 151);
            GazaBastim(GazOranı, this);
        }
    }
}