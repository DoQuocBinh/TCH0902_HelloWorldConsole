using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldConsole
{
    partial class Person:IComparable<Person>
    {
        public string Address { get; set; }

        public int CompareTo(Person otherPerson)
        {
            return Age.CompareTo(otherPerson.Age);
        }
    }
}
