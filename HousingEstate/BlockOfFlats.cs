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

        // constructor
        public BlockOfFlats(HousingEstate he, int number)
        {
            this.Number = number;
            he.allBlocksOfFlats.Add(this);
        }

        // vytvoriť metódu, ktorá automaticky vytvorí vchody - zavolať ju v konštruktore
    }
}
