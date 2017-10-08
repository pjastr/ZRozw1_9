using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Max: {0}", Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Min: {0}", Math.Min(a, Math.Min(b, c)));

            Console.ReadKey();
        }
    }
}
