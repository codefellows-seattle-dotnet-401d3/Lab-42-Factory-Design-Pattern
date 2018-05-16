using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    class ResumeFactory
    {
        public static Page CreatePage(string type)
        {
            Page page = null;

            switch (type)
            {
                case "Work History":
                    page = new WorkHistory();
                    break;
                case "Education":
                    page = new Education();
                    break;
                case "Cover Letter":
                    page = new CoverLetter();
                    break;
                case "Volunteer":
                    page = new Volunteer();
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
