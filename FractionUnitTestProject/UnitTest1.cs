using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FractionLib;

namespace FractionUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorZeroArgument()
        {
            //arrange
            int top = 0, bottom = 1;

            //act
            Fraction f1 = new Fraction();

            //assert
            Assert.AreEqual(top, f1.Top);
            Assert.AreEqual(bottom, f1.Bottom);


        }

        [TestMethod]
        public void ConstructorOneArgument()
        {
            //arrange
            int expectedTop = 2, expectedBottom = 1;

            //act
            Fraction f1 = new Fraction(expectedTop);

            //assert
            int actualTop = f1.Top;
            int actualBottom = f1.Bottom;
            Assert.AreEqual(expectedTop, actualTop);
            Assert.AreEqual(expectedBottom, actualBottom);

        }


        [TestMethod]
        public void ConstructorTwoArgument()
        {
            //arrange
            int expectedTop = 2, expectedBottom = 5;

            //act
            Fraction f1 = new Fraction(expectedTop, expectedBottom);

            //assert
            int actualTop = f1.Top;
            int actualBottom = f1.Bottom;
            Assert.AreEqual(expectedTop, actualTop);
            Assert.AreEqual(expectedBottom, actualBottom);


        }



        [TestMethod]
        public void Addition()
        {
            //arrange
            Fraction f1 = new Fraction(3,5);
            Fraction f2 = new Fraction(1,2);
            int f1Top = f1.Top; 
            int f2Top = f2.Top; 
            int f1Bottom = f1.Bottom;  
            int f2Bottom = f2.Bottom; // left.bottom
            
            //act
            Fraction f3 = f1 + f2;

            //assert
            int expectedTop = (f2Top * f1Bottom) + (f1Top * f2Bottom);
            int expectedBottom = f1Bottom * f2Bottom;
            Assert.AreEqual($"[{expectedTop} , {expectedBottom}]", f3.ToString());

        }

        [TestMethod]
        public void Subtraction()
        {
            //arrange
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(1, 2);
            int f1Top = f1.Top; //right.top
            int f2Top = f2.Top; //left.top
            int f1Bottom = f1.Bottom;  //right.bottom
            int f2Bottom = f2.Bottom; // left.bottom

            //act
            Fraction f3 = f1 - f2;

            //assert
            int expectedTop = (f1Top * f2Bottom) - (f2Top * f1Bottom);
            int expectedBottom = f1Bottom * f2Bottom;
            Assert.AreEqual($"[{expectedTop} , {expectedBottom}]", f3.ToString());
        }

        [TestMethod]
        public void Multiplication()
        {
            //arrange
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(1, 2);
            int f1Top = f1.Top; //right.top
            int f2Top = f2.Top; //left.top
            int f1Bottom = f1.Bottom;  //right.bottom
            int f2Bottom = f2.Bottom; // left.bottom


            //act
            Fraction f4 = f1 * f2;

            //assert
            int expectedTop = f2Top * f1Top;
            int expectedBottom = f1Bottom * f2Bottom;
            Assert.AreEqual($"[{expectedTop} , {expectedBottom}]", f4.ToString());




        }
    }
}
