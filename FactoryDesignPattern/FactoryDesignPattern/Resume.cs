using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class Resume : Document
    {
        public override string FileExtension { get; set; }
        public string ContactInfo { get; set; }
        public List<Company> WorkHistory { get; set; }
    }
}
