using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    // Each Concrete Factory has a corresponding product variant.
    public class MacFactory : IGuiFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteMacButton();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteMacCheckBox();
        }
    }
}
