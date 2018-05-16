using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Page
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
    }
}
