using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoplexNumber
{
   public class MyComplex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public MyComplex(double real, double imaginary = 0)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public MyComplex()
        {
                
        }
        public double Abs() => Math.Sqrt((Real*Real) + (Imaginary*Imaginary));

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {

            return new MyComplex((a.Real + b.Real), (a.Imaginary + b.Imaginary));

        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {

            return new MyComplex((a.Real - b.Real), (a.Imaginary - b.Imaginary));

        }

        public static explicit operator MyComplex(double d)
        {
          return new MyComplex(d, 0);
        }
        public static implicit operator double(MyComplex d)
        {
           return  d.Real  ;
        }
        public override string ToString()
        {
            return $"({Real.ToString()},  {Imaginary.ToString()})";
        }

    }
}
