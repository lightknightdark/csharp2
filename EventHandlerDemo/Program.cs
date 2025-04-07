using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlerDemo
{

    public delegate void MyEventHandler(object sender, EventArgs e);
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby donald = new Baby("trump");
            Baby justin = new Baby("Trudeau");


            Nurse kiers = new Nurse("Kiers");
            Nurse vlad = new Nurse("Volodymir");

            donald.OnHungry += kiers.HungryHandler;
            donald.OnWetDiaper += vlad.DiaperHandler;
            donald.OnSickess += kiers.SickessHandler;


            justin.OnHungry += vlad.HungryHandler;

            Thread t1 = new Thread(donald.RunSimulation);
            Thread t2 = new Thread(justin.RunSimulation);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

        }
    }


    class Nurse //listerner
    { 
    public string Name {get; }
        public Nurse(string name) => this.Name = name;

        public void HungryHandler(object sender, EventArgs e)
            

        => Console.WriteLine($"to be fed by {Name}");

        public void DiaperHandler(object sender, EventArgs e)
     => Console.WriteLine($"to be changed by {Name}");


        public void SickessHandler(object sender, EventArgs e)
     => Console.WriteLine($" {(Baby)sender}to  receive meds from {Name}");

    }



    class Baby
    { 

        Random rnd  = new Random();
    public string Name { get; }

        public event MyEventHandler OnHungry, OnSickess, OnWetDiaper;
        public Baby(string name) =>Name = name;


        public void RunSimulation() {
            while (true)
            {
                Thread.Sleep(1000);
                int evt = rnd.Next(3);
                switch (evt)
                {
                    case 0:
                        OnHungry?.Invoke(this, null);
                        break;
                    case 1:
                        OnSickess?.Invoke(this, null);
                        break;
                    case 3:
                        OnWetDiaper?.Invoke(this, null);
                        break;



                }
            }
        }
    }
}
