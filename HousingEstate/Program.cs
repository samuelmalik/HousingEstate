using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flat flat1 = new Flat(34, 2);
            Flat flat2 = new Flat(52, 3);
            Flat flat3 = new Flat(78, 3);

            Habitant person1 = new Habitant("Oliver", "Krška", 54);
            Habitant person2 = new Habitant("Neolivr", "AntiKrška", 12);
            Habitant person3 = new Habitant("Antioliver", "Nekrška", 25);
            Person cleaner = new Person("Pavel", "Virdzek", 74);

            flat1.AddHabitant(person1);
            flat1.AddHabitant(person2);
            flat2.AddHabitant(person3);

            Console.WriteLine(Flat.GetInfoAboutAllFlats());
            Console.WriteLine(Person.GetInfoAboutAllPeople());
            Console.WriteLine(Person.GetInfoAboutAllNonHabitants());

            // function returning someething like tree structure of all flats and habitants (later can be implemented in Flat class)
            //foreach (var item in Flat.allFlats)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.GetInfoAboutAllInhabitants());
            //}


        }
    }
}
