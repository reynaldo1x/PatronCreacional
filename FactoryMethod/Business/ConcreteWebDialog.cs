using FactoryMethod.Abstract;
using FactoryMethod.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    public class ConcreteWebDialog : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new WebButton();
        }
    }
}
