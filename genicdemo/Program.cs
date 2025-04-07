using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genicdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(4, 5));
            //Console.WriteLine(Add(4.5, 5));
            //int[] result = MakeArray(5, 2);
            //Console.WriteLine($"{string.Join(",",result)}");
            //Console.WriteLine($"{string.Join(",", MakeArray<double>(5.4,2))}");
            //Console.WriteLine($"{string.Join(",", MakeArray<String>("string",2))}");


            int a = 5, b = 1;
            Console.WriteLine($"before swaping a:{a}, b:{b}");

            Swaps<int>(ref a, ref b);
            Console.WriteLine($"after swaping a:{a}, b:{b}");


            string x = "first", y = "second";
            Console.WriteLine($"before swaping x:{x}, y:{y}");
            Swaps<String>(ref x, ref y);
            Console.WriteLine($"after swaping x:{x}, y:{y}");
        }

        static int Add(int a, int b) => a + b;
        static double Add(double a, double b) => a + b;

        //static int[] MakeArray(int value, int size) { 
        
        //var array = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        array[i] = value;
        //    }
        //    return array;
        //}


        //static int[] MakeArray(char value, int size)
        //{

        //    var array = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        array[i] = value;
        //    }
        //    return array;
        //}


        static T[] MakeArray<T>(T value, int size)
        {

            var array = new T[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = value;
            }
            return array;
        }


        static void Swaps<T>(ref T first, ref T second) => (first, second) = (second, first);
    }

}
