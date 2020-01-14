using FactoryMethod.Abstract;
using FactoryMethod.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    /// <summary>
    /// Concrete Creators override the factory method in order to change the
    /// resulting product's type.
    /// </summary>
    public class ConcreteWinDialog : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IProduct FactoryMethod()
        {
            return new WinButton();
        }
    }
}
