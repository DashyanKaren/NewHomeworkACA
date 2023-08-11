using System;
using System.ComponentModel;
using System.Linq;

namespace AverageWithNull
{
    internal class Program
    {
       public static int Res(int?[] x)  
        {
            int?[] ints = new int?[14];
            int count = 0;
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i].HasValue)
                {
                    count++;
                    sum += ints[i].Value;
                }
            }
          return  sum / count;
        }
       public static string HugeSum(string x, string y) 
        {
             var xlength=x.Length;
             var ylength=y.Length;
            bool a = false;
           var X= x.ToCharArray();
            var Y= y.ToCharArray();
             //var xr=x.Reverse();
             //var yr=y.Reverse();

            if (xlength > ylength)
            {
                var sub = xlength - ylength;
                var z = x.Remove(0, sub);
                var Z=z.ToCharArray();
                var z1=x.Remove(sub, (x.Length-sub));
                var Z1 = z1.ToCharArray();
                int[] sum = new int[ylength];

                for (int i = ylength-1; i >0; i--)
                {
                    sum[i] = y[i]+ z[i]+ Convert.ToInt32(a);
                    if (sum[i] > 9)
                    {
                        sum[i] = sum[i] % 10; ;
                       a= true;
                    }
                    else a= false;
                   
                }
                var t = z1 + sum.ToString();
                return t;


            }
            else
            {
                var sub = ylength - xlength;
                var z = y.Remove(0, sub);
                var z1 = y.Remove(sub, y.Length - 1);
                int[] sum = new int[xlength];

                for (int i = 0; i < ylength; i++)
                {
                    sum[i] = Convert.ToInt32(x[i]) + Convert.ToInt32(z[i]) + Convert.ToInt32(a);
                    if (sum[i] > 9)
                    {
                        a = true;
                    }
                    else a = false;

                }
                var t = z1 + (string)sum.ToString();
                return t;
            }

        }
        static void Main(string[] args)
        {
            var t = HugeSum("123456789", "123456");
            Console.WriteLine(t); 
            Console.ReadLine();
        }
    }
}
