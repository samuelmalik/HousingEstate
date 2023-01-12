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
            // create housing estate
            HousingEstate he1 = new HousingEstate("Lunik IX");

            // create blocks of flats and entrances
            BlockOfFlats bof1 = new BlockOfFlats(he1, 1, "Jurčova", 12);
            BlockOfFlats bof2 = new BlockOfFlats(he1, 2, "Richardova", 12);

            // create flats
            int[] flatsAreas = { 60, 87, 75, 95, 68, 79, 96, 77, 82, 96, 82, 88, 68, 71};
            int[] flatsRoomsNumbers = { 2, 4, 3, 2, 2, 2, 3, 2, 3, 3, 2, 3, 2, 2 };

            foreach (var bof in he1.blocksOfFlats)
            {
                foreach (var entrance in bof.entrances)
                {
                    for (int i = 0; i < flatsAreas.Length; i++)
                    {
                        entrance.flats.Add(new Flat(i+1, flatsAreas[i], flatsRoomsNumbers[i]));
                    }
                    
                }
            }


            // create people and add them to flats
            new Habitant("Pavel", "Virdzek", 69 ,he1.blocksOfFlats[0].entrances[4].flats[2]);
            new Habitant("Ján", "Dudešek", 75, he1.blocksOfFlats[0].entrances[4].flats[2]);
            new Habitant("Stanislav", "Lokaj", 55, he1.blocksOfFlats[1].entrances[1].flats[4]);
            new Habitant("Peter", "Sovík", 75, he1.blocksOfFlats[1].entrances[4].flats[2]);
            new Habitant("Peter", "Druska", 38, he1.blocksOfFlats[1].entrances[3].flats[1]);
            new Habitant("Martin", "Cvinček", 43, he1.blocksOfFlats[0].entrances[4].flats[6]);
            new Habitant("Ľubomír", "Baránek", 28, he1.blocksOfFlats[0].entrances[4].flats[7]);
            new Habitant("Ondrej", "Ščamba", 80, he1.blocksOfFlats[1].entrances[8].flats[7]);
            new Habitant("Milan", "Válek", 68, he1.blocksOfFlats[0].entrances[4].flats[1]);
            new Habitant("Anna", "Vojtková", 59, he1.blocksOfFlats[0].entrances[1].flats[2]);
            new Habitant("Jozef", "Uher", 75, he1.blocksOfFlats[0].entrances[1].flats[0]);


            // MENU


            foreach (var bof in he1.blocksOfFlats)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(bof.ToString());
                foreach (var entrance in bof.entrances)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t" + entrance);
                    foreach (var flat in entrance.flats)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\t\t" + flat);
                        foreach (var inhabitant in flat.inhabitants)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t\t" + inhabitant);
                        }
                    }
                }
            }

        }
    }
}
