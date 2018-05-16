using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Document
    {
        protected abstract Page CreatePage(string type);
    }
}
