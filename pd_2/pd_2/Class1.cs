using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class Class1
    {
        public double Reizinasana(double a, double b)
        {
            double result = a * b;
            return result;
        }
        public double Dalisana(double a, double b)
        {
            double result = a / b;
            return result;
        }
        public double Kapinasana()
        {
            double a;
            string input = Console.ReadLine();
            a = Convert.ToDouble(input);
            double b = a * a;
            return b;
        }
    }
}
