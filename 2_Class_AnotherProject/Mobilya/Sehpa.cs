using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilya
{
    public enum SehpaCesit
    {
        OrtaSehpa=1,
        ZigonSehpa,

    }
    internal class Sehpa
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Olcu { get; set; }
        public SehpaCesit SehpaCesit { get; set; }
    }
}
