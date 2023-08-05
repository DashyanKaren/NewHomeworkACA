using System;
using System.Runtime.InteropServices;

namespace MyStringBuilderWithLinkedList
{
    public class LinkedListString
    {
        public Item Head { get; private set; }

        public Item Tail { get; private set; }

        public int Length { get; private set; }

        public LinkedListString(string data)
        {
            var item = new Item(data.ToCharArray());
            SetHeadAndTail(item);
        }

        public override string ToString()
        {
            char[] result = new char[Length];
            var tempHead = Head;
            int index = 0;
            while (tempHead != null)
            {
                for (int i = 0; i < tempHead.Data.Length; i++)
                {
                    result[index] = tempHead.Data[i];
                    index++;
                }
                tempHead = tempHead.Next;
            }

            return new string(result);
        }

        private void SetHeadAndTail(Item item)
        {
            Head = item;
            Tail = item;
            Length = Head.Data.Length;
        }

        public LinkedListString Append(string data)
        {
            if (data==null)
            {
                return this;
            }
            var item = new Item(data.ToCharArray());
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Length += data.Length;

            }
            else { SetHeadAndTail(item); }
            return this;
        }
        public LinkedListString InsertAt(int index, string data)
        {
            if (index<0 || data==null || index>Length)
            {
                return this;
            }
          
            int count = 0;
            int subIndex = index;
            var tempHead = Head;
            
            while (count <= index)
            {
                count += tempHead.Data.Length;
                subIndex -= tempHead.Data.Length;

                if(subIndex < tempHead.Length)
                {
                    break;
                }

                tempHead = tempHead.Next;

            };

            var len = tempHead.Length + data.Length;
            char[] chars = new char[len];

            for (int i = subIndex, j = 0; i < subIndex + data.Length && j < data.Length; i++)
            {
                chars[i] = data[j];
            }

            for (int i = 0, j = subIndex + data.Length, k = subIndex + data.Length; i < Math.Abs(subIndex) && j < len && k < len; i++, j++, k++)
            {
                chars[i] = tempHead.Data[i];
                chars[j] = tempHead.Data[k];
            }

            tempHead.Data = chars;
            return this;

   

        }
    }
}
