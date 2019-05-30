using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ControlPanel
    {
        private ICommand _button1;

        public void SetButton1Command(ICommand command)
        {
            _button1 = command;
        }

        public void Button1Pressed()
        {
            _button1.Execute();
        }
    }
}
