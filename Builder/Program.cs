using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilder("Volkswagen");
            var motorcycle = new MotorcycleBuilder("Ducati");
            var vehicleAssembly = new VehicleAssembly();

            vehicleAssembly.Build(car);
            car.Vehicle.Display();

            vehicleAssembly.Build(motorcycle);
            motorcycle.Vehicle.Display();
        }
    }
}
