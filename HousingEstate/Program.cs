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
            Flat flat1 = new Flat(1, 34, 2);
            Flat flat2 = new Flat(2, 52, 3);
            Person person1 = new Person("Oliver", "Krška", 54);
            Person person2 = new Person("Neolivr", "AntiKrška", 12);
            Person person3 = new Person("Antioliver", "Nekrška", 25);

            flat1.AddInhabitant(person1);
            flat1.AddInhabitant(person2);
            flat2.AddInhabitant(person3);

            Console.WriteLine(flat1.GetInfoAboutAllInhabitants());
            Console.WriteLine(flat2.GetInfoAboutAllInhabitants());

            Console.WriteLine(person1.GetInfoAboutFlat());
            Console.WriteLine(person2.GetInfoAboutFlat());
            Console.WriteLine(person3.GetInfoAboutFlat());



        }
    }
}
