using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Hull : Page
    {
        public Hull(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Hull page done");
        }

        public Hull()
        {

        }
    }
}
