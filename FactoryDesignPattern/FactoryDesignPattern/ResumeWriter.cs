using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class ResumeWriter : Writer
    {
        public override Document Write(string name)
        {
            Resume resume = new Resume
            {
                ContactInfo = "Don't.",
                FileExtension = "ppt",
                History = new WorkHistory(),
                Name = $"{name}'s Resume {DateTime.Now}"
            };
            return resume;
        }
    }
}
