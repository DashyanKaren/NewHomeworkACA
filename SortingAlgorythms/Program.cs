using System;

namespace SortingAlgorythms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] ints = { 13, 22, 3, 0, 3 };
            Console.Write("pleae insert an array =>");
            var t=Console.ReadLine().Split(' ');
            var ints=new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                ints[i] = Convert.ToInt32(t[i]);
             };
            Console.WriteLine("Ansorted Array");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(value: $"{ints[i]}, ");
            }
            Console.WriteLine(  );
            Console.WriteLine("Bubble Sorted "  );
            BubbleSort bubbleSort = new BubbleSort();
            var buble=bubbleSort.Sort(ints);
            for (int i = 0; i < buble.Length; i++)
            {
                Console.Write(buble[i] + ", ");
            }
            Console.WriteLine(  );
            Console.WriteLine( "Selection Sorted" );
            Selection selection = new Selection();
            var select=selection.Sort(ints);
            for (int i = 0; i < select.Length; i++)
            {
                Console.Write(select[i] + ", ");
            }
            Console.WriteLine( );
            Console.WriteLine("Insertion Sorted"  );
            Insertion insertion = new Insertion();
            var insert=insertion.Sort(ints);
            for (int i = 0; i < insert.Length; i++)
            {
                Console.Write(insert[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
