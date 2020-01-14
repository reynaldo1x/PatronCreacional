using FactoryMethod.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    public class WebButton : IProduct
    {
        public string Button()
        {
            return "{Result of WebButton}";
        }
    }
}
