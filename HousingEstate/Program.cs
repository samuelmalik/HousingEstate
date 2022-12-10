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
            Flat flat1 = new Flat(1, 24, 3);
            Person person1 = new Person("Oliver", "Krška", 54);
            Person person2 = new Person("Neolivr", "AntiKrška", 12);
            Person person3 = new Person("Antioliver", "Nekrška", 25);

            flat1.AddHabitant(person1);
            flat1.AddHabitant(person2);
            flat1.AddHabitant(person3);

            foreach (var person in flat1.inhabitants)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
