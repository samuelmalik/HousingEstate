using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Habitant : Person
    {

        // fields
        private Flat flat;

        // properites
        public Flat Flat { get { return flat; } set { flat = value; } }

        // base constructor

        // constructor
        public Habitant(string name, string surname, int age,Flat flat)
        {
            this.name = CapitalizeFirstLetter(name);
            this.surname = CapitalizeFirstLetter(surname);
            this.age = Math.Abs(age);
            this.flat = flat;
            Person.allPeople.Add(this);
        }

        // methods

        // method for getting info about flat
        public string GetInfoAboutFlat()
        {

            return this.flat.ToString();
        }


        // ToString() method
        public override string ToString()
        {
            return String.Format($"{this.name} {this.surname}, {this.age} years old, living in flat {flat.Number}");
        }
    }
}
