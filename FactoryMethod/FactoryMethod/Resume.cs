﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Concrete creator class
    public class Resume : Document
    {
        public void BuildResume()
        {
            CreatePage("Project History");
            CreatePage("Work History");
            CreatePage("Skills");
        }
        //Factory method
        protected override Page CreatePage(string type)
        {
            string[] data = new string[3] { "Resume Title", "Resume Author", "Resume Date" };
            Console.WriteLine($"Resume page {type} in progress");
            return ResumeFactory.CreatePage(type, data);
        }
    }
}
