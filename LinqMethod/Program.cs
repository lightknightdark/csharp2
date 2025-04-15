using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linq;
using System.Threading.Tasks;

namespace LinqMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotUs();
            nameOfUs();
            femaleIndia();
            name();
            gender();
            elements();
            voewls();
            innnerJoin();
            leftJoin();
            rightJoin();
        }

        static void NotUs()
        {
            List<Person> persons = Person.persons;
            Console.WriteLine("1. All non-US citizens:");
            var nonUSCitizens = Person.persons.Where(p => p.Country != "US");
            foreach (var person in nonUSCitizens)
            {
                Console.WriteLine(person);
            }

        }

        static void nameOfUs()
        {
            List<Person> persons = Person.persons;
            var usCitizenNames = Person.persons.Where(p => p.Country == "US").Select(p => p.Name);
            foreach (var name in usCitizenNames)
            {
                Console.WriteLine(name);
            }


        }


        static void femaleIndia()
        {
            List<Person> persons = Person.persons;

            var indianFemales = Person.persons.Where(p => p.IsFemale && p.Country == "India");
            foreach (var person in indianFemales)
            {
                Console.WriteLine(person);
            }

        }




        static void name()
        {
            List<Person> persons = Person.persons;

            var sortedByName = Person.persons.OrderBy(p => p.Name.Split(' ').Last())
                                            .ThenBy(p => p.Name.Split(' ').First());
            foreach (var person in sortedByName)
            {
                Console.WriteLine(person);
            }

        }

        static void gender()
        {

            List<Person> persons = Person.persons;
            var groupedByGender = Person.persons.GroupBy(p => p.IsFemale ? "Female" : "Male");
            foreach (var group in groupedByGender)
            {
                Console.WriteLine($"\nGender: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"  {person.Name}");
                }

            }


        }


        static void words()
        {

            string[] words = "the quick brown fox jumps over the lazy dog".Split();
            var longestWord = words.Aggregate((current, next) =>
                                            next.Length > current.Length ? next : current);
            Console.WriteLine($"6. First longest word: {longestWord}");
            Console.WriteLine();

        }

        private static int CountVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return word.ToLower().Count(c => vowels.Contains(c));
        }

         



        static void voewls()
        {

            string[] words = "the quick brown fox jumps over the lazy dog".Split();
            var wordWithMostVowels = words.Aggregate((current, next) =>
                          CountVowels(next) > CountVowels(current) ? next : current);
            Console.WriteLine($"7. First word with most vowels: {wordWithMostVowels}");
            Console.WriteLine();
        }


        static void elements()
        {
            string[] second = "a b c e".Split();
            string[] third = "a c d e".Split();
            var uniqueElements = second.Concat(third)
                                     .GroupBy(x => x)
                                     .Where(g => g.Count() == 1)
                                     .Select(g => g.Key);
            Console.WriteLine("8. Unique elements in second and third arrays:");
            foreach (var item in uniqueElements)
            {
                Console.WriteLine(item);
            }
        }

        static void innnerJoin()
        {
            List<Fruit> fruits = Fruit.fruits;
            List<Person> persons = Person.persons;

            var innerJoin = persons.Join(
    fruits,
    person => person.Country,
    fruit => fruit.Origin,
    (person, fruit) => new {
        PersonName = person.Name,
        Country = person.Country,
        FruitName = fruit.Name,
        Price = fruit.Price
    });

            Console.WriteLine("Inner Join Results:");
            foreach (var item in innerJoin)
            {
                Console.WriteLine($"{item.PersonName} from {item.Country} - {item.FruitName} (${item.Price})");
            }


        }



        static void leftJoin() {
            List<Fruit> fruits = Fruit.fruits;
            List<Person> persons = Person.persons;
            var leftJoin = persons.GroupJoin(
    fruits,
    person => person.Country,
    fruit => fruit.Origin,
    (person, fruitGroup) => new {
        Person = person,
        Fruits = fruitGroup
    })
    .SelectMany(
        x => x.Fruits.DefaultIfEmpty(),
        (x, fruit) => new {
            PersonName = x.Person.Name,
            Country = x.Person.Country,
            FruitName = fruit?.Name ?? "No fruit",
            Price = fruit?.Price ?? 0
        });

            Console.WriteLine("\nLeft Join Results:");
            foreach (var item in leftJoin)
            {
                Console.WriteLine($"{item.PersonName} from {item.Country} - {item.FruitName} (${item.Price})");
            }


        }

        static void rightJoin() {
            List<Fruit> fruits = Fruit.fruits;
            List<Person> persons = Person.persons;

            var rightJoin = fruits.GroupJoin(
    persons,
    fruit => fruit.Origin,
    person => person.Country,
    (fruit, personGroup) => new {
        Fruit = fruit,
        Persons = personGroup
    })
    .SelectMany(
        x => x.Persons.DefaultIfEmpty(),
        (x, person) => new {
            FruitName = x.Fruit.Name,
            Origin = x.Fruit.Origin,
            Price = x.Fruit.Price,
            PersonName = person?.Name ?? "No person",
            Country = person?.Country ?? "N/A"
        });

            Console.WriteLine("\nRight Join Results:");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"{item.FruitName} from {item.Origin} (${item.Price}) - {item.PersonName} from {item.Country}");
            }


        }




    }
}
