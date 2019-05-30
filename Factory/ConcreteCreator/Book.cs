using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Book : Document
    {
        protected override void CreatePages()
        {
            _pages.Add(new TableOfContentsPage());
            _pages.Add(new IntroductionPage());
            _pages.Add(new DetailPage());
            _pages.Add(new ConclusionPage());
        }
    }
}
