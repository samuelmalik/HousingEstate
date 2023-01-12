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
        private int capacity = 4;
        private int currentSpace;

        // list of inhabitants
        public List<Person> inhabitants = new List<Person>();

        // properties
        public int Number { get { return number; } }
        public int Area { get { return area; } set { area = Math.Abs(value); } }
        public int RomsNumber { get { return roomsNumber; } set { roomsNumber = Math.Abs(value); } }
        public int CurrentSpace { get { return currentSpace; } set { currentSpace = value; } }

        // constructor
        public Flat(int number, int area, int roomsNumber)
        {
            this.area = Math.Abs(area);
            this.roomsNumber = Math.Abs(roomsNumber);
            Flat.allFlats.Add(this);
            this.number = number;
        }

        // methods
        
        // method for adding habitatnts
        public void AddHabitant(Habitant habitant)
        {
            inhabitants.Add(habitant);
            habitant.Flat = this;
        }

        // method for getting info about all habitants
        public string GetInfoAboutAllHabitants()
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
            Console.ForegroundColor = ConsoleColor.Blue;
            return String.Format($"Flat number {this.number} with {this.roomsNumber} rooms and total area of {this.area} square meters.");
        }

    }
}
