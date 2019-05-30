using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Light
    {
        private bool _lightState = false;

        public void Switch(bool lightState)
        {
            _lightState = lightState;

            if (_lightState)
            {
                Console.WriteLine($"Light is on");
            }
            else
            {
                Console.WriteLine("Light is off");
            }
        }
    }
}
