using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class WorkHistory
    {
        public List<Company> Companies { get; set; }

        public WorkHistory()
        {
            Company c1 = new Company { Position = "Butler",
                                       HireDate = new DateTime(1939, 05, 31),
                                       Name = "Wayne Industries" };
            Companies = new List<Company> { c1 };
        }
        }
    }


    public struct Company
    {
        public string Position;
        public string Name;
        public DateTime HireDate;
    }
}
