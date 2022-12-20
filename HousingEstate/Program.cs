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
            he1.blocksOfFlats.Add(bof1);
            BlockOfFlats bof2 = new BlockOfFlats(he1, 2, "Richardova", 15);
            he1.blocksOfFlats.Add(bof2);


            foreach (var entrance in bof1.entrances)
            {
                Console.WriteLine(entrance); 
            }


            // create flats

            

            // create people

            // add people to flats

            // MENU


            // function returning someething like tree structure of all flats and habitants (later can be implemented in Flat class)
            //foreach (var item in Flat.allFlats)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.GetInfoAboutAllInhabitants());
            //}


        }
    }
}
