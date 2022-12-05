using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Flat
    {
        // fields
        private int number;
        private int area;
        private int roomsNumber;

        // list of inhabitants
        public List<Person> inhabitants = new List<Person>();

        // properties
        public int Number { get { return number; } set { number = value; } }
        public int Area { get { return area; } set { area = value; } }
        public int RomsNumber { get { return roomsNumber; } set { roomsNumber = value; } }

        // constructor
        public Flat(int number, int area, int roomsNumber)
        {
            this.number = number;
            this.area = area;
            this.roomsNumber = roomsNumber;
        }

        // ToString() method
        public override string ToString()
        {
            return String.Format($"This is flat number {this.number} with {this.roomsNumber} rooms and total area of {this.area} square meters.");
        }

    }
}
