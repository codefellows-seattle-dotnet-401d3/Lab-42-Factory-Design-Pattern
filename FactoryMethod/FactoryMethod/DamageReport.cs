using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DamageReport : Document
    {
        public void BuildReport()
        {
            CreatePage("Hull");
            CreatePage("Casualties");
            CreatePage("Inventory");
        }

        protected override Page CreatePage(string type)
        {
            string[] data = new string[3] { "DamageReport Title", "DamageReport Author", "DamageReport Date" };
            Console.WriteLine($"DamageReport page {type} in progress");
            return ResumeFactory.CreatePage(type, data);
        }
    }
}
