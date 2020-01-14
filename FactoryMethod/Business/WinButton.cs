using FactoryMethod.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    /// <summary>
    /// Concrete Products provide various implementations of the Product
    /// interface.
    /// </summary>
    public class WinButton : IProduct
    {
        public string Button()
        {
            return "{Result of WinButton}";
        }
    }
}
