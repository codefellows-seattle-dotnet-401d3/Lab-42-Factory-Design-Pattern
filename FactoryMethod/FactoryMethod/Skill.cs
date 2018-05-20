using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Concrete product class
    public class Skill : Page
    {
        public Skill(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Skill page done");
        }

        public Skill()
        {

        }
    }
}
