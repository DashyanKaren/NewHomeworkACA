namespace MyStringBuilder
{
    internal class MyStringBuilder
    {
        public string MyString { get; set; }

        public MyStringBuilder(string str)
        {
            MyString = str;   
        }

        public MyStringBuilder()
        {
        }

        public int Length(string str) => str.Length;
        
        public string Append(string str) 
        {
            //var x = Length(MyString); 
            //var y = Length(str);
            //var z = y + x;
            //char[] chars = new char[z];
            //for (int i = 0; i < x; i++)
            //{
            //    chars[i] = MyString[i];
            //}
            //for (int i = x, j=0; i < z && j<y; i++, j++)
            //{
            //    chars[i] = str[j];

            //}
            //return new string(chars);
            MyString += str;
            return MyString;
        }

        public string InsertAt(string str, int index) 
        {
            var x = Length(MyString);
            var y = Length(str);
            var z = y + x;
            char[] chars = new char[z];
            for (int i = 0; i <= index; i++)
            {
                chars[i] = MyString[i];
            }
            for (int i = index, j = 0; i <= z-y+index && j < y; i++, j++)
            {
                chars[i] = str[j];
            }
            for (int i = x-index+1, j=x - index + y + 1; i < x && j<=z ; i++,j++)
            {
                chars[j] = MyString[i];
            }
            return new string(chars);
        }
    }
}
