using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class HousingEstate
    {
        // list of all blocks of flats
        public List<BlockOfFlats> blocksOfFlats = new List<BlockOfFlats>();
 
        // properties
        public string Name { get; set; }

        // constructor
        public HousingEstate(string name)
        {
            this.Name = name;
        }

    }
}
