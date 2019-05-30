using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Switch(true);
        }
    }
}
