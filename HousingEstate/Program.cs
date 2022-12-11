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

            Person person1 = new Person("Oliver", "Krška", 54);
            Person person2 = new Person("Neolivr", "AntiKrška", 12);
            Person person3 = new Person("Antioliver", "Nekrška", 25);

            flat1.AddInhabitant(person1);
            flat1.AddInhabitant(person2);
            flat2.AddInhabitant(person3);

            Console.WriteLine(Flat.GetInfoAboutAllFlats());
            Console.WriteLine(Person.GetInfoAboutAllPeople());

            // function returning someething like tree structure of all flats and habitants (later can be implemented in Flat class)
            //foreach (var item in Flat.allFlats)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.GetInfoAboutAllInhabitants());
            //}


        }
    }
}
