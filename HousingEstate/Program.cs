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
                        entrance.flats.Add(new Flat(flatsAreas[i], flatsRoomsNumbers[i]));
                    }
                    
                }
            }


            // create people

            // add people to flats

            // MENU


            foreach (var bof in he1.blocksOfFlats)
            {
                Console.WriteLine(bof.ToString());
                foreach (var entrance in bof.entrances)
                {
                    Console.WriteLine("\t" + entrance);
                    foreach (var flat in entrance.flats)
                    {
                        Console.WriteLine("\t\t" + flat);
                    }
                }
            }

        }
    }
}
