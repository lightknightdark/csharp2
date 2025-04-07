using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatedemo
{
    internal class Program
    {

        delegate void Signor(); // store any method that no args and retrun any args . step 2 declare the delegate
        static void Main(string[] args)
        {
            //STEP 2 : intiialziing the delegate
            Signor picasso = new Signor(Picasso);
            Signor pic = Picasso; //referecne the method by the name of method as it is static.

            Signor foo =AnotherClass.Foo;
            Signor bar = new AnotherClass().Bar;


            //step 4: invoking the methid
            picasso();
            pic();
            foo();
            bar?.Invoke();

            Signor all = picasso + foo + bar;

            all();
        }

        static void Picasso() // methid that i want to sotre in delegate, step 1 declare sample method
            => Console.WriteLine("Done by Picasso");



        class AnotherClass
        { 
        public static void Foo()
                  => Console.WriteLine("Done by Foo");

            public  void Bar()
                  => Console.WriteLine("Done by Bar");

        }
    }
}
