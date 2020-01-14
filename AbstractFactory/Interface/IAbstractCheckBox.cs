using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface
{
    // Here's the the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    public interface IAbstractCheckBox
    {
        // Product B is able to do its own thing...
        string CreateCheckBox();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherUsefulFunctionB(IAbstractButton collaborator);
    }
}
