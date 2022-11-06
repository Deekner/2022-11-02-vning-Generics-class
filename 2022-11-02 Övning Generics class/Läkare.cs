using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_Övning_Generics_class
{
    public class Läkare : Person
    {

        public int workID { get; set; }
        public string name { get; set; }
        public string salary { get; set; }
        public string workHours { get; set; }

        public void SkrivaRecept()
        {
            Console.WriteLine("Doctor wrote a recept");
        }

    }
}
