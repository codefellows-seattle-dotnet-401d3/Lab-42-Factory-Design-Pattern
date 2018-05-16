using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    class TPSReport : Document
    {
        protected override Page CreatePage(string type)
        {
            Console.WriteLine("Create your TPS report before it is too late");
            return TPSReportFactory.CreatePage(type);
        }
    }
}
