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

            double a, b, e, c, f;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            
            e = a / b;
         


           
            Console.WriteLine(e);
          
            c = a - b;


            Console.WriteLine(c);



            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
           
            f = a * b;
          
          


    
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}