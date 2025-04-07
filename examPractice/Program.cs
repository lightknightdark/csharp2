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
            dictionary();
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

        static void hashSet() {
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
            country.Add("Guyana", new List<string>{"Banana", "Plaintain", "Mango", "Cashew"} );
            country.Add("New Zeeland", new List<string>{ " Kiwi", "Apple", " Avocado", " Cherry" } );
            country.Add(" Ecuador", new List<string>{"Banana"} );
            country.Add("Spain", new List<string>{ " Persimmon", " Orange", "Mango", " Mandarin" } );
            country.Add("Canada", new List<string>{ " Blueberry"} );
            country.Add("Russia", new List<string>{ " Strawberry"} );
            country.Add("Israel", new List<string>{ " Persimmon", " Dates", " Pomegranates"} );
            country.Add("China", new List<string>{ " Dragon Fruit", "Apple", "Pear", "Cherry","Mandarin"} );
            country.Add("Chile", new List<string>{"Figs", " Avocado", " Blueberry", "Cherry","Ggrape","Plum" } );
            country.Add("Guatemala", new List<string> { "Banana", "Pinapple", "Papaya" } );
            country.Add("Mexico", new List<string> { "Lemon", " Tomato", "Blueberry","Avvado" } );



            foreach (var item in country)
            {
                counter++;
                Console.WriteLine($"{counter} : {item.Key}: {string.Join(",",item.Value)}");
            }

        }

    }
}
