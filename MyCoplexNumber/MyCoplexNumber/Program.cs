using System;
using System.Numerics;

namespace MyCoplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(-3, 4);
           // Console.WriteLine(  complex);
            //Complex.Abs(complex);
            //Console.WriteLine(Complex.Abs(complex));

            MyComplex myC=new MyComplex(3,4);
            MyComplex myC1=new MyComplex(-2,5);
            Console.WriteLine( myC);
            var z =myC.Abs();
            Console.WriteLine(z);
            var t = myC + myC1;
            Console.WriteLine(t);

        }

      
    }
}
