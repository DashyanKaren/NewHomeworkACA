using System;

namespace SortingAlgorythms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] ints = { 13, 22, 3, 0, 3 };
            var buble=bubbleSort.Sort(ints);
            for (int i = 0; i < buble.Length; i++)
            {
                Console.Write(buble[i] + ", ");
            }
            Console.WriteLine(  );
            Selection selection = new Selection();
            var select=selection.Sort(ints);
            for (int i = 0; i < select.Length; i++)
            {
                Console.Write(select[i] + ", ");
            }
            Console.WriteLine(  );
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
