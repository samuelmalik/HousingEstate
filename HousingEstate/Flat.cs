using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Flat
    {
        // STATIC MEMBERS

        // list of all existing flats
        public static List<Flat> allFlats = new List<Flat>();

        // method for getting info about all existing flats
        public static string GetInfoAboutAllFlats()
        {
            string info = String.Empty;
            foreach (var flat in Flat.allFlats)
            {
                info += flat + "\n";
            }
            return info.Substring(0, info.Length - 1);
        }


        // CLASS MEMBERS

        // fields
        private int number;
        private int area;
        private int roomsNumber;

        // list of inhabitants
        public List<Person> inhabitants = new List<Person>();

        // properties
        public int Number { get { return number; } set { number = Math.Abs(value); } }
        public int Area { get { return area; } set { area = Math.Abs(value); } }
        public int RomsNumber { get { return roomsNumber; } set { roomsNumber = Math.Abs(value); } }

        // constructor
        public Flat(int number, int area, int roomsNumber)
        {
            this.number = Math.Abs(number);
            this.area = Math.Abs(area);
            this.roomsNumber = Math.Abs(roomsNumber);
            Flat.allFlats.Add(this);
        }

        // methods
        
        // method for adding habitatnts
        public void AddInhabitant(Person habitant)
        {
            inhabitants.Add(habitant);
            habitant.CurrentFlat = this;
        }

        // method for getting info about all habitants
        public string GetInfoAboutAllInhabitants()
        {
            string info = String.Empty;
            foreach (var person in this.inhabitants)
            {
               info += "\t" + person + "\n";
            }
            return info.Substring(0, info.Length - 1);
        }

        // ToString() method
        public override string ToString()
        {
            return String.Format($"Flat number {this.number} with {this.roomsNumber} rooms and total area of {this.area} square meters.");
        }

    }
}
