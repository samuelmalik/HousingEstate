using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class BlockOfFlats
    {
        // properties
        public int Number { get; set; }
        public string Street { get; set; }

        // lists
        public List<Entrance> entrances = new List<Entrance>();


        // constructor
        public BlockOfFlats(HousingEstate he, int number, string street, int entrancesNumber)
        {
            this.Number = number;
            this.Street = street;
            he.blocksOfFlats.Add(this);
            CreateEntrances(entrancesNumber);
        }

        // Method for automatic creating entrances

        public void CreateEntrances(int entrancesNumber)
        {
            // loop for odd numbers
            for (int i = 1; i <= entrancesNumber; i++)
            {
                if (i%2 !=0)
                {
                    this.entrances.Add(new Entrance(i, this));
                }
               
            }

            // loop for even numbers
            for (int i = 2; i <= entrancesNumber; i++)
            {
                if (i % 2 == 0)
                {
                    this.entrances.Add(new Entrance(i, this));
                }

            }

        }

    }
}
