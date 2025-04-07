using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq;

namespace QuerySyntaxDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample02();
        }


        static void Sample() { 
        List<Person> persons = Person.persons;
            Console.WriteLine("\n\nSample1");
            var r1 =
                from p in persons
                select p;
            int count = 1;
            foreach (Person p in persons)
            {
                Console.WriteLine($"{count++},{p}");
            }
  
        }


        static void Sample02() {
            List<Person> persons = Person.persons;
            Console.WriteLine("\n\nSample2");
            var r = 
                from p in persons
                where p.IsFemale
                select p;
            int count = 1;
            foreach (var item in r)
            {
                Console.WriteLine($"{count++} :{item}");
            }
           
        }
    }
}
