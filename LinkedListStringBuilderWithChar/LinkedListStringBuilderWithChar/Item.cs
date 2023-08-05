using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStringBuilderWithChar
{
    internal class Item
    {
        
        private char[] data=null;
        public char[] Data
        {
            
            get { return data; }
            set
            {
                if (value != null) data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }
        public Item  Next { get; set; }
        public Item(char[] data)
        {
            Data = data;
        }

    }
}
