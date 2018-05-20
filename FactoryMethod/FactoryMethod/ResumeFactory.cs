using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Concrete creator class
    public class ResumeFactory
    {
        public static Page CreatePage(string type, string[] data)
        {
            Page page = null;

            switch (type)
            {
                case "Project History":
                    page = new Project(data);
                    break;
                case "Work History":
                    page = new Work(data);
                    break;
                case "Skills":
                    page = new Skill(data);
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
