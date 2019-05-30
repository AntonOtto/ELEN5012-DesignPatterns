using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Switch(false);
        }
    }
}
