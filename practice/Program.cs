using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practice.Program;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
               hashSetFruit();
             hashSetCountry();
            fruitCountry();
            listOfFruitNameAndOrigin();
        }

        public class Fruit
        {
            public string Name { get; set; }
            public string Origin { get; set; }
            public double Price { get; set; }
            public override string ToString()
            {
                return $"{Name} @{Price:c} ({Origin.Substring(0, 2).ToUpper()})";
            }
            public static List<Fruit> fruits = new List<Fruit>()
  {
    new Fruit(){ Name="Banana", Origin="Guyana", Price=1.23},
    new Fruit(){ Name="Plaintain", Origin="Guyana", Price=2.82},
    new Fruit(){ Name="Mango", Origin="Guyana", Price=5.62},
    new Fruit(){ Name="Cashew", Origin="Guyana", Price=3.57},
    new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=2.30},
    new Fruit(){ Name="Apple", Origin="New Zeeland", Price=1.54},
    new Fruit(){ Name="Avocado", Origin="New Zeeland", Price=1.66},
    new Fruit(){ Name="Cherry", Origin="New Zeeland", Price=4.25},
    new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
    new Fruit(){ Name="Persimmon", Origin="Spain", Price=2.36 },
    new Fruit(){ Name="Orange", Origin="Spain", Price=1.25 },
    new Fruit(){ Name="Mandarin", Origin="Spain", Price=1.54 },
    new Fruit(){ Name="Blueberry", Origin="Canada", Price=1.29 },
    new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
    new Fruit(){ Name="Persimmon", Origin="Israel", Price=1.36 },
    new Fruit(){ Name="Dates", Origin="Israel", Price=0.19 },
    new Fruit(){ Name="Pomegranates", Origin="Israel", Price=0.45 },
    new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
    new Fruit(){ Name="Apple", Origin="China", Price=1.36 },
    new Fruit(){ Name="Pear", Origin="China", Price=2.18 },
    new Fruit(){ Name="Pomelo", Origin="China", Price=0.45 },
    new Fruit(){ Name="Cherry", Origin="China", Price=4.49 },
    new Fruit(){ Name="Mandarin", Origin="China", Price=1.45 },
    new Fruit(){ Name="Figs", Origin="Chile", Price=1.36 },
    new Fruit(){ Name="Avocado", Origin="Chile", Price=1.19 },
    new Fruit(){ Name="Blueberry", Origin="Chile", Price=0.19 },
    new Fruit(){ Name="Cherry", Origin="Chile", Price=0.45 },
    new Fruit(){ Name="Grape", Origin="Chile", Price=1.19 },
    new Fruit(){ Name="Plum", Origin="Chile", Price=0.19 },
    new Fruit(){ Name="Pineapple", Origin="Guatemala", Price=1.36 },
    new Fruit(){ Name="Banana", Origin="Guatemala", Price=0.19 },
    new Fruit(){ Name="Papaya", Origin="Guatemala", Price=0.45 },
    new Fruit(){ Name="Lemon", Origin="Mexico", Price=2.56},
    new Fruit(){ Name="Tomato", Origin="Mexico", Price=2.56},
    new Fruit(){ Name="Blueberry", Origin="Mexico", Price=2.56},
    new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
  };
        }



        static void hashSetFruit() {
            HashSet<string> fruitNameSet = new HashSet<string>();
            foreach (var fruit in Fruit.fruits)
            {
                fruitNameSet.Add(fruit.Name);
            }


            int counter = 1;
            foreach (var name in fruitNameSet)
            {
                Console.WriteLine($" {counter}: {name}");
                counter++;
            }
        }



        static void hashSetCountry() {
            HashSet<string> exportingCountries = new HashSet<string>();

            foreach (var fruit in Fruit.fruits)
            {
                exportingCountries.Add(fruit.Origin);
            }

            int counter = 1;
            foreach (var country in exportingCountries)
            {
                Console.WriteLine($" {counter}: {country}");
                counter++;
            }

        }



        static void fruitCountry() {
            Dictionary<string, List<string>> countryFruitMap = new Dictionary<string, List<string>>();
            foreach (var fruit in Fruit.fruits)
            {
                // If the country is already a key in the dictionary,
                if (countryFruitMap.ContainsKey(fruit.Origin))
                {
                    // Add the current fruit's name to the existing list for that country.
                    countryFruitMap[fruit.Origin].Add(fruit.Name);
                }
                else
                {
                    // If the country is not yet a key, create a new list with the current fruit's name
                    // and add it to the dictionary with the country as the key.
                    countryFruitMap[fruit.Origin] = new List<string> { fruit.Name };
                }
            }


            int counter = 1;
            foreach (var entry in countryFruitMap)
            {
                Console.WriteLine($" {counter}: {entry.Key}: {string.Join(", ", entry.Value)}");
                counter++;
            }

        }


        static void fruitName(){
            Dictionary<string, List<string>> fruitOriginMap = new Dictionary<string, List<string>>();
            foreach (var fruit in Fruit.fruits)
            {
                // If the country is already a key in the dictionary,
                if (fruitOriginMap.ContainsKey(fruit.Name))
                {
                    // Add the current fruit's name to the existing list for that country.
                    fruitOriginMap[fruit.Name].Add(fruit.Origin);
                }
                else
                {
                    // If the country is not yet a key, create a new list with the current fruit's name
                    // and add it to the dictionary with the country as the key.
                    fruitOriginMap[fruit.Name] = new List<string> { fruit.Origin};
                }
            }


            int counter = 1;
            foreach (var entry in fruitOriginMap)
            {
                Console.WriteLine($" {counter}: {entry.Key}: {string.Join(", ", entry.Value)}");
                counter++;
            }


        }


        static void listOfFruitNameAndOrigin()
        {
            Console.WriteLine("Question 1d: Create a List of list of fruit name and origin");

            // Initialize a List of List of strings.
            List<List<string>> fruitNameOriginList = new List<List<string>>();

            // Iterate through the list of fruits.
            foreach (var fruit in Fruit.fruits)
            {
                // Create a new inner list containing the fruit name and origin.
                List<string> innerList = new List<string> { fruit.Name, fruit.Origin };
                // Add the inner list to the main list.
                fruitNameOriginList.Add(innerList);
            }

            Console.WriteLine($"Type: {fruitNameOriginList.GetType()}");

            // Print the list of lists in the desired format.
            int counter = 1;
            foreach (var innerList in fruitNameOriginList)
            {
                Console.WriteLine($" {counter}: {string.Join(", ", innerList)}");
                counter++;
            }
        }

    }
}
