using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_demo2
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                try
                {

                    GenerateRandomException();
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                catch (NullReferenceException e2)
                {
                    Console.WriteLine(e2.Message);
                }
                catch (InvalidOperationException e3)
                {
                    Console.WriteLine(e3.Message);
                }
                catch (Exception e4)
                {
                    Console.WriteLine(e4.Message);
                }

            }
        }


        static void GenerateRandomException() { 
        int type = rnd.Next(7); //generate number less than 7
            switch (type) { 
            case 0:
                    throw new IndexOutOfRangeException();
                    break;
            case 1:
                   throw  new NullReferenceException();
                    break ;
            case 2:
                    throw new InvalidOperationException();
                    break;
            
            }
        
        }
    }
}
