using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Person
    {
        // fields
        private string name;
        private string surname;
        private int age;

        // properties
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }

        // constructor
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        // ToString method
        public override string ToString()
        {
            return String.Format($"My name is {this.name} {this.surname} and I am {this.age} years old");
        }
    }
}
