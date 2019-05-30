using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var _airport = new Airport();

            _airport.Attach(new Airline(_airport, "South African Airways"));
            _airport.Attach(new Airline(_airport, "British Airways"));
            _airport.Attach(new Airline(_airport, "Delta Airlines"));

            _airport.RunwayTemperature = "50 degrees";
            _airport.Notify();
        }
    }
}
