using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MotorcycleBuilder : VehicleBuilder
    {

        public MotorcycleBuilder(string name)
        {
            _vehicle = new Vehicle(name);
        }

        public override void SetNumberOfWheels()
        {
            _vehicle.NumberOfWheels = 2;
        }
    }
}
