using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    public class ConcreteMacCheckBox : IAbstractCheckBox
    {
        public string CreateCheckBox()
        {
            return "The result of the checkbox.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractButton collaborator)
        {
            var result = collaborator.CreateButton();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
