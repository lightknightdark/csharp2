using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labweek7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Lizard> lizards = Lizard.CreateLizard();
            int counter = 1;
            foreach (var item in lizards)
            {
                Console.WriteLine($"{counter++}: {lizards}");
            }
        }
    }

    enum LizardColor
    { 
    
    Black,
    Brown,
    Green,
    Yellow,
    Red,
    Grey
    
    }
    class Lizard { 
    public string Species { get; set; }
    public int Quantity { get; set; }
    public bool IsDangerous { get; set; }
    public LizardColor Color { get; set; }


        public Lizard(string Species, int Quantity, bool IsDangerous, LizardColor Color) {
            this.Species = Species; 
            this.Quantity = Quantity;
            this.IsDangerous = IsDangerous;
            this.Color = Color;
        
        
        }

        public override string ToString() => $"{Species} {Quantity} {(IsDangerous ? "is" : "not")}dangerous";


        public static List<Lizard> CreateLizard() 
        {
        return new List<Lizard>() { 
        
        
        
        };
        
        }
    
    }
}
