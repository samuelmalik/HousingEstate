using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Entrance
    {
        // STATIC MEMBERS


        // CLASS MEMBERS

        // flat list
        public List<Flat> inhabitants = new List<Flat>();

        // properties
        public int Number { get; set; }
        public BlockOfFlats BlockOfFlats { get; set; }


        // constructor
        public Entrance(int number, BlockOfFlats bof)
        {
            this.Number = number;
            this.BlockOfFlats = bof;
        }

        // ToString() method
        public override string ToString()
        {
            return String.Format($"Entrance number {this.Number}");
        }
    }
}
