using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DamageReportFactory
    {
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns>Damage Report Page based on peram</returns>
        public static Page CreatePage(string type, string[] data)
        {
            Page page = null;

            switch (type)
            {
                case "Hull":
                    page = new Hull(data);
                    break;
                case "Casualties":
                    page = new Casualty(data);
                    break;
                case "Inventory":
                    page = new Inventory(data);
                    break;
                default:
                    break;
            }
            return page;
        }
    }
}
