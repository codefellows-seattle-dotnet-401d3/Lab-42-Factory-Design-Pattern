using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class CoverLetter : Document
    {
        public string TextBody { get; set; }
        public string TargetCompany { get; set; }
    }
}
