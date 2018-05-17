using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class CoverLetter : Document
    {
        public override string FileExtension { get; set; }
        public string TextBody { get; set; }
        public string TargetCompany { get; set; }
    }
}
