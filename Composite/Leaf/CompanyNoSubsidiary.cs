using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CompanyNoSubsidiary : Company
    {
        public CompanyNoSubsidiary(string name) : base(name)
        {

        }
        public override void AddSubsidiary(Company subsidiary)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Company: {_name}");
        }
    }
}
