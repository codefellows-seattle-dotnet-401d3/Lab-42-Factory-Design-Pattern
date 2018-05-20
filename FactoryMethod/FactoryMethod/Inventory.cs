using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Inventory : Page
    {
        //Concrete product class
        public Inventory(string[] data)
        {
            Title = data[0];
            Author = data[1];
            Date = data[2];

            Console.WriteLine("Inventory page done");
        }

        public Inventory()
        {

        }
    }
}
