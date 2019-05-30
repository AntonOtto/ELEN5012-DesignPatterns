using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var company1 = new CompanyNoSubsidiary("First Company");
            var company2 = new CompanyNoSubsidiary("Second Company");

            var holdingCompany = new HoldingCompany("Holding Company");
            holdingCompany.AddSubsidiary(company1);
            holdingCompany.AddSubsidiary(company2);

            holdingCompany.Display();
        }
    }
}
