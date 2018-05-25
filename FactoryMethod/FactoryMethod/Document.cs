using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Abstract creator class
    public abstract class Document
    {
        protected abstract Page CreatePage(string type);
    }
}
