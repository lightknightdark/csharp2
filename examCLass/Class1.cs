using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examCLass
{
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
}
