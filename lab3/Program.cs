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
            double a, b, f;
            double a, b, e, c;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            
            e = a / b;
         


           
            Console.WriteLine(e);
          
            c = a - b;
           
            f = a * b;
          
          


    
            Console.WriteLine(f);

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}