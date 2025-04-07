using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fraction_Calculator_GUI
{
    public class Fraction

    {

        public int Top { get; }

        public int Bottom { get; }


        public Fraction(int top = 0, int bottom = 1)

            => (Top, Bottom) = (top, bottom);


        public Fraction(string top = "0", string bottom = "1")
        {
            if (!int.TryParse(top, out int parsedTop))
            {
                throw new ArgumentException("Invalid top string. Must be an integer.", nameof(top));
            }

            if (!int.TryParse(bottom, out int parsedBottom))
            {
                throw new ArgumentException("Invalid bottom string. Must be an integer.", nameof(bottom));
            }

            if (parsedBottom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(bottom));
            }

           this.Top = parsedTop;
            this.Bottom = parsedBottom;

        }

     //   => (Top, Bottom) = (top, bottom);


        public static Fraction operator +(Fraction lhs, Fraction rhs)

            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);



        public static Fraction operator -(Fraction lhs, Fraction rhs)

            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);


        public static Fraction operator *(Fraction left, Fraction right)
           => new Fraction(left.Top * right.Top, left.Bottom * right.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)

            => new Fraction(rhs.Top * lhs.Bottom, lhs.Top * rhs.Bottom);




        public override string ToString()

            => $"[{Top}, {Bottom}]";

      

        public void Deconstruct(out string top, out string bottom)

            => (top, bottom) = ($"{Top}", $"{Bottom}");

    }


}
