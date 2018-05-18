using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class Class2
    {
        public double Perimetrs()
        {
            string input = Console.ReadLine();
           double a = Convert.ToDouble(input);
            string input2 = Console.ReadLine();
           double b = Convert.ToDouble(input2);
            string input3 = Console.ReadLine();
           double c = Convert.ToDouble(input3);
            double d = a + b + c;
            return d;
        }
    }
}
