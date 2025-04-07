using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //   HashSetDemo();
            DictionaryDemo();
        }


        static void DictionaryDemo() {
            Dictionary<int, string> courses = new Dictionary<int, string>();

            courses.Add(100, "programming 1");
            courses.Add(123, "programming 2");
            courses.Add(213, "Web Page design");
            courses.Add(255, "Software requirement");
            courses.Add(301, "Lunix");
            courses.Add(122, "Database 1 ");
            courses.Add(125, "Client Side Javascript 1 ");

            Console.WriteLine($"{string.Join("\n", courses)}");

            courses[301] = "Lunix operating System";

            int key = 305;

            Console.WriteLine($"{key} is {(courses.ContainsKey(key) ? "not " : "") } present as a key");

             key = 225;

            Console.WriteLine($"{key} is {(courses.ContainsKey(key) ? "not " : "")} present as a key");


            string value = "programming 1";
            Console.WriteLine($"{value} is {(courses.ContainsValue(value) ? "not " : "")} present as avalue");


            value = "Game Programming 1";
            Console.WriteLine($"{key} is {(courses.ContainsKey(key) ? "not " : "")} present as a key");
            //
            courses[305] = "Game Programming 1";
            Console.WriteLine($"There are {courses.Count} pairs in the collection");
            Console.WriteLine($"{courses[key]}  corrspind to the key {key}");




        }

        static void HashSetDemo() {
            //creating a set
            HashSet<int> set = new HashSet<int>();


            int[] ints = { 1, 2, 3, 3, 2, 6, 7 };
            set = new HashSet<int>(ints);

            //printing the set

            foreach (int i in set) {
                Console.Write($"{i}, ");
            
            }

            Console.WriteLine($"\n\n{string.Join(",",set)}");
            int number = 9;

            Console.WriteLine($"{number} is {(set.Contains(number)? "" : "not")} in the set");


            set.Add(number);
            Console.WriteLine($"{number} is {(set.Contains(number)? "" : "not")} in the set");

            //remove 1 from the set

            number = 1;
            set.Remove(number);

            Console.WriteLine($"\n\n{string.Join(",", set)}");

            Console.WriteLine($"there are {set.Count()} item(s) in the set");

        }
    }
}
