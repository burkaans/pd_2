using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Aprekins1(7, 3));
            Console.WriteLine(Aprekins2(10, 3));
            Console.ReadLine();
        }
        static double Aprekins1(double a, double b)
        {
            double result = a + b;
            return result;
        }
        static double Aprekins2(double a, double b)
        {
            double result = a - b;
            return result;
        }
    }
}
