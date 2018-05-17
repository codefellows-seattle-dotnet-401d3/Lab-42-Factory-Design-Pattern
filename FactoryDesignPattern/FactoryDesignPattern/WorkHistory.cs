using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class WorkHistory
    {
        public List<Company> Companies { get; set; }
    }

    public struct Company
    {
        public string Position;
        public string Name;
        public DateTime HireDate;
    }
}
