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

            // create blocks of flats
            BlockOfFlats bof1 = new BlockOfFlats(he1, 1, "Jurčova", 12);
            BlockOfFlats bof2 = new BlockOfFlats(he1, 2, "Richardova", 12);

            // in each block of flats create entrances




            // create flats



            // create people

            // add people to flats

            // MENU


            foreach (var bof in he1.blocksOfFlats)
            {
                Console.WriteLine(bof.ToString());
                foreach (var entrance in bof.entrances)
                {
                    Console.WriteLine("\t" + entrance);
                }
            }

        }
    }
}
