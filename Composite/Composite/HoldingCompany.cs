using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class HoldingCompany : Company
    {
        private List<Company> _subsidiaries = new List<Company>();

        public HoldingCompany(string name) : base(name)
        {

        }

        public override void AddSubsidiary(Company subsidiary)
        {
            _subsidiaries.Add(subsidiary);
        }

        public override void Display()
        {
            Console.WriteLine($"Holding Company: {_name}");

            foreach(var subsidiary in _subsidiaries)
            {
                subsidiary.Display();
            }
        }
    }
}
