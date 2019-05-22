using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double a, b, e;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            c = a - b;
            
            
            e = a / b;
         


           
            Console.WriteLine(e);
          

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}