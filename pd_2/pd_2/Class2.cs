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
        public double Saskaitisana()
        {
            Console.WriteLine("Ievadiet pirmo skaitli");
            double skaitlis1, skaitlis2;
            string input1 = Console.ReadLine();
            skaitlis1 = Convert.ToDouble(input1);
            Console.WriteLine("ievadiet +/-");
            string input2 = Console.ReadLine();
            Console.WriteLine("Ievadiet otro skaitli");
            string input3 = Console.ReadLine();
            skaitlis2 = Convert.ToDouble(input3);
            double rezultats1, rezultats2;
            rezultats1 = skaitlis1 + skaitlis2;
            rezultats2 = skaitlis1 - skaitlis2;
            return rezultats1;
            return rezultats2;
            if (input2 == "+")
            {
              Console.WriteLine(rezultats1);
            }
                if (input2 == "-")
            {
              Console.WriteLine(rezultats2);
            }

           

        }
    }
}
