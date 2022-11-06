using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_Övning_Generics_class
{
    class Patient : Person
    {
        public string sjukdom { get; set; }
        public double timeOfReg { get; set; }
        public double timeOfDisCharge { get; set; }
        public bool Recept { get; set; }
    }
}
