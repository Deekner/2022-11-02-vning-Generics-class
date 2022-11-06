using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_Övning_Generics_class
{
    public class TestGeneric
    {
        public bool Compare <T>(T value1, T Value2)
        {
            return value1.Equals(Value2);
        }

    }
}
