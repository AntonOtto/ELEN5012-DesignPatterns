using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlPanel = new ControlPanel();

            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            controlPanel.SetButton1Command(lightOn);
            controlPanel.Button1Pressed();

            controlPanel.SetButton1Command(lightOff);
            controlPanel.Button1Pressed();


        }
    }
}
