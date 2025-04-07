using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   hashSet();
          //  dictionary();
            orinigalCountry();
        }


        //q1:
        //        Question 1a: Create a HashSet of all the fruit names
        //Type: System.Collections.Generic.HashSet`1[System.String]
        //  1: Banana
        //  2: Plaintain
        //  3: Mango
        //  4: Cashew
        //  5: Kiwi
        //  6: Apple
        //  7: Avocado
        //  8: Cherry
        //  9: Persimmon
        // 10: Orange
        // 11: Mandarin
        // 12: Blueberry
        // 13: Strawberry
        // 14: Dates
        // 15: Pomegranates
        // 16: Dragon Fruit
        // 17: Pear
        // 18: Pomelo
        // 19: Figs
        // 20: Grape
        // 21: Plum
        // 22: Pineapple
        // 23: Papaya
        // 24: Lemon
        // 25: Tomato

        static void hashSet()
        {
            int counter = 0;
            HashSet<String> fruit = new HashSet<String>();
            fruit.Add("Banana");
            fruit.Add("Plaintain");
            fruit.Add("Mango");
            fruit.Add("Cashew");
            fruit.Add("Kiwi");
            fruit.Add("Apple");
            fruit.Add("Avocado");
            fruit.Add("Cherry");
            fruit.Add("Persimmon");
            fruit.Add("Orange");
            fruit.Add("Mandarin");
            fruit.Add("Blueberry");
            fruit.Add("Strawberry");
            fruit.Add("Dates");
            fruit.Add("Pomegranates");
            fruit.Add("Dragon Fruit");
            fruit.Add("Pear");
            fruit.Add("Pomelo");
            fruit.Add("Figs");
            fruit.Add("Grape");
            fruit.Add("Plum");
            fruit.Add("Pineapple");
            fruit.Add("Papaya");
            fruit.Add("Lemon");
            fruit.Add("Tomato");

            foreach (string item in fruit)
            {
                counter++;
                Console.WriteLine($"{counter} : {item}");
            }

        }

        //Question 1b: Create a Dictionary of Countries with the fruits exports (as a list)
        //       Type: System.Collections.Generic.Dictionary`2[System.String, System.Collections.Generic.List`1[System.String]]
        // 1: Guyana: Banana, Plaintain, Mango, Cashew
        // 2: New Zeeland: Kiwi, Apple, Avocado, Cherry
        // 3: Ecuador: Banana
        // 4: Spain: Persimmon, Orange, Mandarin
        // 5: Canada: Blueberry
        // 6: Russia: Strawberry
        // 7: Israel: Persimmon, Dates, Pomegranates
        // 8: China: Dragon Fruit, Apple, Pear, Pomelo, Cherry, Mandarin
        // 9: Chile: Figs, Avocado, Blueberry, Cherry, Grape, Plum
        //10: Guatemala: Pineapple, Banana, Papaya
        //11: Mexico: Lemon, Tomato, Blueberry, Avocado
        static void dictionary()

        {

            int counter = 0;
            Dictionary<String, List<string>> country = new Dictionary<string, List<string>>();
            country.Add("Guyana", new List<string> { "Banana", "Plaintain", "Mango", "Cashew" });
            country.Add("New Zeeland", new List<string> { " Kiwi", "Apple", " Avocado", " Cherry" });
            country.Add(" Ecuador", new List<string> { "Banana" });
            country.Add("Spain", new List<string> { " Persimmon", " Orange", "Mango", " Mandarin" });
            country.Add("Canada", new List<string> { " Blueberry" });
            country.Add("Russia", new List<string> { " Strawberry" });
            country.Add("Israel", new List<string> { " Persimmon", " Dates", " Pomegranates" });
            country.Add("China", new List<string> { " Dragon Fruit", "Apple", "Pear", "Cherry", "Mandarin" });
            country.Add("Chile", new List<string> { "Figs", " Avocado", " Blueberry", "Cherry", "Ggrape", "Plum" });
            country.Add("Guatemala", new List<string> { "Banana", "Pinapple", "Papaya" });
            country.Add("Mexico", new List<string> { "Lemon", " Tomato", "Blueberry", "Avvado" });



            foreach (var item in country)
            {
                counter++;
                Console.WriteLine($"{counter} : {item.Key}: {string.Join(",", item.Value)}");
            }

        }

        // 1: Banana: Guyana, Ecuador, Guatemala
        //   2: Plaintain: Guyana
        //   3: Mango: Guyana
        //   4: Cashew: Guyana
        //   5: Kiwi: New Zeeland
        //   6: Apple: New Zeeland, China
        //   7: Avocado: New Zeeland, Chile, Mexico
        //   8: Cherry: New Zeeland, China, Chile
        //   9: Persimmon: Spain, Israel
        //  10: Orange: Spain
        //  11: Mandarin: Spain, China
        //  12: Blueberry: Canada, Chile, Mexico
        //  13: Strawberry: Russia
        //  14: Dates: Israel
        //  15: Pomegranates: Israel
        //  16: Dragon Fruit: China
        //  17: Pear: China
        //  18: Pomelo: China
        //  19: Figs: Chile
        //  20: Grape: Chile
        //  21: Plum: Chile
        //  22: Pineapple: Guatemala
        //  23: Papaya: Guatemala
        //  24: Lemon: Mexico
        //  25: Tomato: Mexico

        static void orinigalCountry()

        {

            int counter = 0;
            Dictionary<String, List<string>> country = new Dictionary<string, List<string>>();
            country.Add("Banana", new List<string> { "Guyana", "Ecuador", "Guatemala" });
            country.Add("Mango", new List<string> { "Guyana" });
            country.Add("Cashew", new List<string> { "Guyana" });
            country.Add("Kiwi", new List<string> { "New Zeeland" });
            country.Add("Apple", new List<string> { "New Zeeland", "China" });
            country.Add("Avocado", new List<string> { " New Zeeland", "Chile", "Mexico" });
            country.Add("Cherry", new List<string> { " New Zeeland", "China", "Chile" });
            country.Add("Persimmon", new List<string> { " Spain", "Israel" });
            country.Add("Orange", new List<string> { "Spain" });
            country.Add("Mandarin", new List<string> { " Spain", "China" });
            country.Add("Blueberry", new List<string> { "Canada", "Chile", "Mexico" });
            country.Add("Strawberry", new List<string> { " Russia" });
            country.Add("Dates", new List<string> { " Israel" });
            country.Add("Pomegranates", new List<string> { " Israel" });
            country.Add("Dragon Fruit", new List<string> { "China" });
            country.Add("Pear", new List<string> { "China" });
            country.Add("Pomelo", new List<string> { "China" });
            country.Add("Figs", new List<string> { "Chile" });
            country.Add("Grape", new List<string> { "Chile" });
            country.Add("Plum", new List<string> { "Chile" });
            country.Add("Pineapple", new List<string> { "Guatemala" });
            country.Add("Papaya", new List<string> { "Guatemala" });
            country.Add("Lemon", new List<string> { " Mexico" });
            country.Add("Tomato", new List<string> { " Mexico" });

            foreach (var item in country)
            {
                counter++;
                Console.WriteLine($"{counter} : {item.Key}: {string.Join(",", item.Value)}");
            }

        }


    }
}
