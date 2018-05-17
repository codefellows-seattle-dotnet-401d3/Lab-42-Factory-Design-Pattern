using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class Resume : Document
    {
        public string ContactInfo { get; set; }
        public WorkHistory History { get; set; }
    }
}
