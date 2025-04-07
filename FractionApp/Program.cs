using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionLib;

namespace FractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1,5);
            Console.WriteLine(f1);
            Fraction f2 = new Fraction(3,5);
            Console.WriteLine(f2);

            Fraction f3 = f1 + f2;
            Console.WriteLine(f3);

            Fraction f4 = f2 - f1;
            Console.WriteLine(f4);

            Fraction f5 = f1 * f2;
            Console.WriteLine(f5);
        }
    }
}
