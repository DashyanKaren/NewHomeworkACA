using System;

namespace MyStringBuilderWithLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedListString("abc");
            list.Append("aaaa");
            list.Append("bbbb");
            list.Append("cccc");
            Console.WriteLine(list.ToString()); 

            list.Append("dddd");
            Console.WriteLine(list.ToString());
            list.InsertAt(5, "TTT");
            Console.WriteLine(list.ToString());



        }
    }
}
