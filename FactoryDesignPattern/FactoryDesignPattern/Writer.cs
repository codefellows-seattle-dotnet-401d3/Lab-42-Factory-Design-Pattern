using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    abstract public class Writer
    {
        string Name { get; set; }
        public abstract Document Write(string name);
    }
}
