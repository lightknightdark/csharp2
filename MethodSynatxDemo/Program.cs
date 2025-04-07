using Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSynatxDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample();
            Sample01();
        }
        static void Sample()
        {
         //   List<Person> persons = Person.persons;
            Console.WriteLine("\n\nSample1");
            var r1 = Person.persons
                .Where(persons => persons.IsFemale)
                .Select(q => new { q.Name,Gender =  (q.IsFemale ? "F" :"M") });
            int count = 1;
            foreach (var item in r1)
            {
                Console.WriteLine($"{count++},{item}");
            }

        }

        static void Sample01()
        {
            //   List<Person> persons = Person.persons;
            Console.WriteLine("\n\nSample1");
            var r1 = Person.persons
                .OrderBy(x => x.Country);
               
            int count = 1;
            foreach (var item in r1)
            {
                Console.WriteLine($"{count++},{item}");
            }

        }
    }
}
