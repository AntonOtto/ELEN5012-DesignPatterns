using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Report : Document
    {
        protected override void CreatePages()
        {
            _pages.Add(new SummaryPage());
            _pages.Add(new DetailPage());
        }
    }
}
