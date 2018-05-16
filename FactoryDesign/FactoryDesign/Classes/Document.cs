using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    public abstract class Document
    {
        protected abstract Page CreatePage(string type);

        public Page WritePage(string type)
        {
            Page page = CreatePage(type);

            return page;
        }
    }
}
