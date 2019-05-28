using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 8; // номер варианта 8
            Console.WriteLine("x = ");
            double x = double.Parse(Console.ReadLine());
            double f;
            if (Math.Abs(x) < 10)
            {
                Console.WriteLine("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("b = ");
                double b = double.Parse(Console.ReadLine());
                f = Math.Tan(x / i + a) - Math.Log10(Math.Abs(b * i + 7));
            } else
            {
                Console.WriteLine("c = ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("d = ");
                double d = double.Parse(Console.ReadLine());
                f = c * Math.Pow( (Math.Pow(x, 2) + d * Math.Pow(i, 1.2) ), 1.0/i);
            }
            Console.WriteLine("f = " + f);
        }
    }
}
