using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteWinButton : IAbstractButton
    {
        public string CreateButton()
        {
            return "The result of the button.";
        }
    }
}
