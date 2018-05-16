using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Project : Page
    {
        public Project(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Project page done");
        }

        public Project()
        {

        }
    }
}
