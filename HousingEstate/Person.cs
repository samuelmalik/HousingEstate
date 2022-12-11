using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Person
    {
        // STATIC MEMBERS

        // list of people not living here
        public static List<Person> nonHabitants = new List<Person>();

        // list of all existing people
        public static List<Person> allPeople = new List<Person>();

        // method for getting info about all existing people
        public static string GetInfoAboutAllPeople()
        {
            string info = String.Empty;
            foreach (var person in Person.allPeople)
            {
                info += person + "\n";
            }
            return info.Substring(0, info.Length - 1);
        }

        // method for getting info about all people that are not living here
        public static string GetInfoAboutAllNonHabitants()
        {
            string info = String.Empty;
            foreach (var person in Person.nonHabitants)
            {
                info += person + "\n";
            }
            return info.Substring(0, info.Length - 1);
        }


        // CLASS MEMBERS

        // method converting first letter to upper
        protected string CapitalizeFirstLetter(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }

        // fields
        protected string name;
        protected string surname;
        protected int age;
        

        // properties
        public string Name { get { return name; } set { name = CapitalizeFirstLetter(value); } }
        public string Surname { get { return surname; } set { surname = CapitalizeFirstLetter(value); } }
        public int Age { get { return age; } set { age = Math.Abs(value); } }

        // base constructor
        public Person()
        {
            this.name = "Name";
            this.surname = "Surname";
            this.age = 18;
        }

        // constructor
        public Person(string name, string surname, int age)
        {
            this.name = CapitalizeFirstLetter(name);
            this.surname = CapitalizeFirstLetter(surname);
            this.age = Math.Abs(age);
            Person.allPeople.Add(this);
            Person.nonHabitants.Add(this);
        }


        // ToString() method
        public override string ToString()
        {
            return String.Format($"{this.name} {this.surname}, {this.age} years old, not living here");
        }
    }
}
