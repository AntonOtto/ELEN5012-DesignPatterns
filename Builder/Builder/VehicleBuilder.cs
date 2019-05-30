using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public abstract void SetNumberOfWheels();
    }
}
