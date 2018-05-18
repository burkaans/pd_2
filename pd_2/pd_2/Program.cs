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

            int izvele = 1;

            while (izvele != 0)
            {
                Console.WriteLine("1- Izvadit saskaitisanas funkciju");
                Console.WriteLine("2- izvadit atnemsanas funkciju");
                Console.WriteLine("0- Iziet");

                string input = Console.ReadLine();
                izvele = Convert.ToInt16(input);

                switch (izvele)
                {
                    case 1:
                        Console.WriteLine(Aprekins1(3, 7));
                        break;
                    case 2:
                        Console.WriteLine(Aprekins2(10, 7));
                        break;
                    case 0:
                        izvele = 0;
                        break;
                    default:
                        Console.WriteLine("Ievade nav pareiza");
                        break;
                }
            }
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
