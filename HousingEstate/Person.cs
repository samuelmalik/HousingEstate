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


        // CLASS MEMBERS

        // method converting first letter to upper
        private string CapitalizeFirstLetter(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }

        // fields
        private string name;
        private string surname;
        private int age;
        private Flat currentFlat;

        // properties
        public string Name { get { return name; } set { name = CapitalizeFirstLetter(value); } }
        public string Surname { get { return surname; } set { surname = CapitalizeFirstLetter(value); } }
        public int Age { get { return age; } set { age = Math.Abs(value); } }
        public Flat CurrentFlat { get { return currentFlat; } set { currentFlat = value; } }

        // constructor
        public Person(string name, string surname, int age)
        {
            this.name = CapitalizeFirstLetter(name);
            this.surname = CapitalizeFirstLetter(surname);
            this.age = Math.Abs(age);
            Person.allPeople.Add(this);
        }

        // methods

        // method for getting info about flat
        public string GetInfoAboutFlat()
        {

            return this.currentFlat.ToString();
        }


        // ToString() method
        public override string ToString()
        {
            return String.Format($"{this.name} {this.surname}, {this.age} years old.");
        }
    }
}
