using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum DolapCesit
    {       
        Ahsap = 1,  
        Plastik,
        Bez,       
    }
    public class Dolap
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Olcu { get; set; }
        public string KulpCesiti { get; set; }  
        public DolapCesit DolapCesit { get; set; }
    }
}
