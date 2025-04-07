using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_v
{
    internal class Program
    {

        static int Division(int top, int bottom)

            => top /= bottom;

        static void Main(string[] args)
        {
            //    DivisionNoHandling();
            DivisionWithExceptionHandling();
        }

        static void DivisionNoHandling()
        {
            Division(1, 0);

        }

        static void DivisionWithExceptionHandling()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        static void DivisionWithExceptionHandlingAndThrow()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Division by zero ia not permitted");
            }

        }
    }
}
