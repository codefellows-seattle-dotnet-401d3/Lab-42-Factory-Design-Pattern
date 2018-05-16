using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    class TPSReportFactory
    {
        public static Page CreatePage(string type)
        {
            Page page = null;

            switch (type)
            {
                case "Time Report":
                    page = new TimeReport();
                    break;
                case "Progress Report":
                    page = new ProgressReport();
                    break;
                case "Status Report":
                    page = new StatusReport();
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
