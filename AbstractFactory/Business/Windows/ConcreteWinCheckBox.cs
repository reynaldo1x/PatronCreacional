using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteWinCheckBox : IAbstractCheckBox
    {
        public string CreateCheckBox()
        {
            return "The result of the checkbox.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractButton collaborator)
        {
            var result = collaborator.CreateButton();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
