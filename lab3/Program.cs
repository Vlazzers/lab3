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

            double a, b, e, c, f, d;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
           
            e = a / b;
            
            c = a - b;
           
            f = a * b;
       
            d= a + b;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}