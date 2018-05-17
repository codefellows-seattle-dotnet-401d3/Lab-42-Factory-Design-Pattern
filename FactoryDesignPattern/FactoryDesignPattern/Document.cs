using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    abstract public class Document
    {
        public string Name { get; set; }
        abstract public string FileExtension { get; set; }
    }
}
