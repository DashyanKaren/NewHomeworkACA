using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Person
{
    internal class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        
        //Can be declared in seperate class
        public int CourseNumber { get; }
        public string Department { get; }

        public override string ToString()
        {
            return "I'm student";
        }
    }
}
