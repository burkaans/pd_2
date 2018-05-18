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
            if (a < 0)
            {
                Console.WriteLine("kluda, skaitlis nedrikst but negativs!");
            }
            string input2 = Console.ReadLine();
           double b = Convert.ToDouble(input2);
            if (b < 0)
            {
                Console.WriteLine("kluda, skaitlis nedrikst but negativs!");
            }
            string input3 = Console.ReadLine();
           double c = Convert.ToDouble(input3);
            if (c < 0)
            {
                Console.WriteLine("kluda, skaitlis nedrikst but negativs!");
            }
            double d = a + b + c;
                return d;
            
        }
    }
}
