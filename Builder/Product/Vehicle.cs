using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Vehicle
    {
        private string _name;
        private int _numberOfWheels;

        public Vehicle(string name)
        {
            _name = name;
        }

        public int NumberOfWheels
        {
            set { _numberOfWheels = value; }
        }

        public void Display()
        {
            Console.WriteLine($"Vehicle is {_name} and has {_numberOfWheels} wheels.");
        }
    }
}
