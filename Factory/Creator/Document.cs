using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Document
    {
        protected List<Page> _pages = new List<Page>();

        public Document()
        {
            CreatePages();
        }

        protected abstract void CreatePages();

        public void PrintPages()
        {
            foreach(var page in _pages)
            {
                Console.WriteLine(page.GetType().Name);
            }
        }
    }
}
