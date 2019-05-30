using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Airline : IAirline
    {
        private string _airlineName;
        private string _runwayTemperature;

        public Airline(Airport airport, string airlineName)
        {
            Airport = airport;
            _airlineName = airlineName;
        }

        public void Update()
        {
            _runwayTemperature = Airport.RunwayTemperature;
            Console.WriteLine($"Airline {_airlineName}, received runway temperature figure is: {_runwayTemperature}");
        }

        public Airport Airport { get; set; }
    }
}
