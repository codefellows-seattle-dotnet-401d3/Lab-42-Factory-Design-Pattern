using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Casualty : Page
    {
        //Concrete product class
        public Casualty(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Casualty page done");
        }

        public Casualty()
        {

        }
    }
}
