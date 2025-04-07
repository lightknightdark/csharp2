using Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab25_linq_query_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assets();
            //noUS();
            //femaleIndia();
            //lenghtLessTahnFive();
            //sortAssets();
            //groupCountry();
        }

        static void Assets() {
            Console.WriteLine("Select all the persons with assets of over 50B dollars");
            List<Person> persons = Person.persons;

            var r1 =
                from p in persons
                where p.Asset > 50.0
                select p;

            int count = 1;
            foreach (Person p in r1)
            {
                Console.WriteLine($"{count++},{p}");
            }
        }

        static void noUS()
        {
            Console.WriteLine("Select all non-US citizens");
            List<Person> persons = Person.persons;
            var r1 =
                from p in persons
                where p.Country != "US"
                select p;

            int count = 1;
            foreach (Person p in r1)
            {
                Console.WriteLine($"{count++},{p}");
            }
        }

        static void femaleIndia()
        {
            Console.WriteLine("Select the name of all the females from India.");
            List<Person> persons = Person.persons;
            var r1 =
                   from p in persons
                   where p.IsFemale && p.Country == "India"
                   select p.Name;

            int count = 1;
            foreach(string p in r1)
            {
                Console.WriteLine($"{count++},{p}");
            }
        }

        static void lenghtLessTahnFive()
        {
            Console.WriteLine("Select all persons whose first name is less than five letters long..");
            List<Person> persons = Person.persons;
            var r3 =
                   from p in persons
                   where p.Name.Split(' ')[0].Length < 5 
                   select p.Name;

            int count = 1;
            foreach (string p in r3)
            {
                Console.WriteLine($"{count++},{p}");
            }
        }

        static void sortAssets()
        {
            Console.WriteLine("Sort the collection by assets. ");
            List<Person> persons = Person.persons;
            var r1 =
                from p in persons
                orderby p.Asset
                select p;

            int count = 1;
            foreach (Person p in r1)
            {
                Console.WriteLine($"{count++},{p.Name} ,{p.Asset}");
            }
        }

        static void groupCountry()
        {
            Console.WriteLine("Group the collection by country. ");
            List<Person> persons = Person.persons;
            var r1 =
                from p in persons
                group p by p.Country into country_group
                select country_group;

            int count = 1;
            foreach (Person p in r1)
            {
                Console.WriteLine($"{count++},{(string.Join("",p))}");
            }
        }

        static void sortGroupCountry()
        {
            Console.WriteLine("Group the collection by country. ");
            List<Person> persons = Person.persons;
            var r1 =
                from p in persons
                group p by p.Country into country_group
                orderby country_group.Key
                select country_group;

            int count = 1;
            foreach (Person p in r1)
            {
                Console.WriteLine($"{count++},{(string.Join("", p))}");
            }
        }


        static void firstLastNameGroup() {
            // Query 8a: Group by first letter of last name and count people in each group
            var query8a = from p in Person.persons
                          group p by p.Name.Split()[0].Substring(0, 1) into letterGroup
                          orderby letterGroup.Key
                          select new { Letter = letterGroup.Key, Count = letterGroup.Count() };

            Console.WriteLine("8a. Count of people by first letter of last name:");
            foreach (var group in query8a)
            {
                Console.WriteLine($"- {group.Letter}: {group.Count} people");
            }
        }

        static void averageCountry() {
            //Average assets by country
            var query8b = from p in Person.persons
                          group p by p.Country into countryGroup
                          select new
                          {
                              Country = countryGroup.Key,
                              AverageAssets = countryGroup.Average(p => p.Asset)
                          };

            Console.WriteLine("8b. Average assets by country:");
            foreach (var item in query8b)
            {
                Console.WriteLine($"- {item.Country}: {item.AverageAssets:F2}B");
            }
        }

        static void topWealthiest() {
            //Top 3 wealthiest people in each country
            var query8c = from p in Person.persons
                          group p by p.Country into countryGroup
                          select new
                          {
                              Country = countryGroup.Key,
                              Wealthiest = (from p in countryGroup
                                            orderby p.Asset descending
                                            select p).Take(3)
                          };

            Console.WriteLine("8c. Top 3 wealthiest people in each country:");
            foreach (var country in query8c)
            {
                Console.WriteLine($"Country: {country.Country}");
                foreach (var person in country.Wealthiest)
                {
                    Console.WriteLine($"  - {person.Name}: {person.Asset}B");
                }
            }

        }

   






    }
}
