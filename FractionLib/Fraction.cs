using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; set; }

        public Fraction(int top = 0, int bottom = 1)
        => (Top, Bottom) = (top, bottom);

        public override string ToString()
        {
            return $"[{Top} , {Bottom}]";
        }

        public static Fraction operator +(Fraction left, Fraction right)
            => new Fraction((left.Top * right.Bottom) + (right.Top * left.Bottom), left.Bottom * right.Bottom);


        public static Fraction operator -(Fraction left, Fraction right)
            => new Fraction((left.Top * right.Bottom) - (right.Top * left.Bottom), left.Bottom * right.Bottom);

        public static Fraction operator *(Fraction left, Fraction right)
          => new Fraction(left.Top * right.Top, left.Bottom * right.Bottom);

    }
}
