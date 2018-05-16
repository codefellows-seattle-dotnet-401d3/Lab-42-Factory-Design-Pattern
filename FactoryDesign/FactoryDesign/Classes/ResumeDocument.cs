using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    class ResumeDocument : Document
    {
        protected override Page CreatePage(string type)
        {
            Console.WriteLine("Create a Resume to get a job!");
            return ResumeFactory.CreatePage(type);
        }
    }
}
