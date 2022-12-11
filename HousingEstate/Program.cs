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
            BlockOfFlats bof1 = new BlockOfFlats(he1, 14);
            BlockOfFlats bof2 = new BlockOfFlats(he1, 15);

            // create entrances


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
