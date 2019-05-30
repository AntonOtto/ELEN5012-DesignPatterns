using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class VehicleAssembly
    {
        public void Build(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.SetNumberOfWheels(); 
        }
    }
}
