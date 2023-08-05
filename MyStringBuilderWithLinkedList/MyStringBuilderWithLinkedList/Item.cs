using System;

namespace MyStringBuilderWithLinkedList
{
    public class Item
    {
        public char[] Data { get; set; }
        public Item Next { get; set; }
        public int Length { get => Data.Length;  }
        
        public Item(char[] data)
        {
            Data = data;
        }
      

        public override string ToString() => Data.ToString();
    }
}
