using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Work : Page
    {
        public Work(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Work page done");
        }

        public Work()
        {

        }
    }
}
