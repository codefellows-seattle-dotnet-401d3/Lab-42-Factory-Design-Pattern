using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Concrete creator class
    public class Resume : Document
    {
        /// <summary>
        /// Test method meant to build three different pages
        /// </summary>
        public void BuildResume()
        {
            CreatePage("Project History");
            CreatePage("Work History");
            CreatePage("Skills");
        }
        
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected override Page CreatePage(string type)
        {
            string[] data = new string[3] { "Resume Title", "Resume Author", "Resume Date" };
            Console.WriteLine($"Resume page {type} in progress");
            return ResumeFactory.CreatePage(type, data);
        }
    }
}
