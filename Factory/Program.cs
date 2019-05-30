using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var _documents = new List<Document>
            {
                new Book(),
                new Report()
            };

            foreach (var document in _documents)
            {
                Console.WriteLine($"Printing pages for {document.GetType().Name}");
                document.PrintPages();
            }
        }
    }
}
