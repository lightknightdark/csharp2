using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlarmClockDemo
{


    public delegate void TimeEventHandler(object sender, TimeEventArgs e);
    internal class Program
    {
        static void Main(string[] args)
        {
            Emmiter clock = new Emmiter(); 

            Listener justin =  new Listener(1,10,"Justin");
            clock.OnAlarm += justin.AlarmHandler;

            Listener nardendra = new Listener(3, 30, "Marendra");
            clock.OnAlarm += justin.AlarmHandler;
            clock.RunSimlation();
        }
    }
    //emmiter or producer or publish
    class Emmiter
    {

        public event TimeEventHandler OnAlarm;
        public int Hour { get; set; }
        public int Minute { get; set; }

        public void RunSimlation() {

            while (true)
            {
                Thread.Sleep(1000);
                Minute++;
                if (Minute >= 0) {
                    Hour++;
                    Minute %= 60;
                }

                if (Hour >= 24) { 
                Hour %= 24;
                }

                if(Minute %10 == 0)
                {
                    Console.Write($"\r{Hour:d2}:{Minute:d2} ");
                    //emit an alarm

                    OnAlarm?.Invoke(this, new TimeEventArgs(Hour, Minute));

                }
            }
        }

    }

    //listerer/customer//subscriber

    class Listener
    {
        int hour, minute;
        public string Name { get; set; }

        public Listener(int h, int m, string name) => (hour, minute, Name) = (h, m, name);

        public void AlarmHandler(object sender, TimeEventArgs e)
        {
            if (e.Hour == hour && e.Minute == minute) { Console.Write($"\n{hour:d2}:{minute:d2} it is time for {Name} to get up  "); }
        
        }

    }


   public class TimeEventArgs : EventArgs
    { 
    public int Hour { get; }
        public int Minute { get; }
        public TimeEventArgs(int hour, int minute) : base() => (Hour, Minute) = (hour, minute);
       
    }
}
