using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class WinFactory : IGuiFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteWinButton();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteWinCheckBox();
        }
    }
}
