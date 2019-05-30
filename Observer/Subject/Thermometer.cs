using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Thermometer
    {
        private List<IAirline> _airlines = new List<IAirline>();

        public void Attach(IAirline airline)
        {
            _airlines.Add(airline);
        }

        public void Detach(IAirline airline)
        {
            _airlines.Remove(airline);
        }

        public void Notify()
        {
            foreach(var airline in _airlines)
            {
                airline.Update();
            }
        }
    }
}
