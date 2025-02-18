using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_sayson
{
    class Fahrenheit_ToKelvin
    {
        public static double Convert(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }
    }
}
