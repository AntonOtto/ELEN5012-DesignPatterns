using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder(string name)
        {
            _vehicle = new Vehicle(name);
        }

        public override void SetNumberOfWheels()
        {
            _vehicle.NumberOfWheels = 4;
        }
    }
}
