using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.Müzik_Aletleri
{
    //Abstract classlar sadece kalitim vermek icin tasarlanmistir. Instance alinamazlar.
    // Yani new'lenemezler

    internal abstract class MuzikAleti
    {

        public string Marka { get; set; }
        public string Aciklama { get; set; }

        //Abstract Class larin en buyuk ozelligi de icerisinde Abstract olan yada olmayan metodlari barindirabilirler.
        // Abstract metodlar kalitim alinan yerde implimente edilmek zorundadir.
        //Yani Metodun govdesi kalitim alinan yerde yazilacaktir. InterfaceDeki gibi metod imzasi yeterlidir.
        public abstract string Cal();
        //public static  abstract string Cal(string ses);

        public virtual string AkortEt()
        {
            return Marka + " Akor Edildi";

        }
        /*
         
         Abstract Metodlari tanijmlarken dikkart edilmesi gerekenler
         
         1- Abstract metodlar private olarak isaretlenemezler.
         2-Abstract metodlar sadece abstract classlarda tanimlanabilir
         3-Abstract metodlar static olarak tanimlanamazlar. Statik kavrami class 
           ozelligi yada metod ozelligi oldugundan instance cikarmaya gerek yoktur.
           Halbukli statik olmayan metodlar instnace metodlar.
        4- Abstract metodlarin govdesi olmaz .
        5- Abstract metodlar virtual olarak tanimlanamazlar. Abstract metodlar metod imzasi ile calisir. Govdesi yoktur.
           Virtual metodlarin govdesi vardir. 
        6- Virtaul metodlar inherit verdigi yerlerde ovveride edilebilirler. Yani Govdesi yeniden tanimlanabilir
         */


    }
}
