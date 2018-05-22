using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Concrete creator class
    public class ResumeFactory
    {
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns>Resume page</returns>
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
