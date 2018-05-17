using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class ResumeWriter : Writer
    {
        public override Document Write(string name)
        {
            Resume resume = new Resume();
            resume.ContactInfo = "Don't.";
            resume.FileExtension = "ppt";
            resume.WorkHistory = new List<Company>();
            resume.Name = $"{name}'s Resume {DateTime.Now}";
            return resume;
        }
    }
}
