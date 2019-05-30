using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Company
    {
        protected string _name;

        public Company(string name)
        {
            _name = name;
        }

        public abstract void AddSubsidiary(Company subsidiary);
        public abstract void Display();
    }
}
