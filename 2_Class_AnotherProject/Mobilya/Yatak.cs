using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum YatakEbat
    {
        TekKisilik = 1,
        CiftKisilik,
        KingSizeTek,
        KingSizeCift,
        SupekKingSizeCift

    }
    public class Yatak
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Olcu { get; set; }
        public YatakEbat YatakEbat { get; set; }
        
    }
}
