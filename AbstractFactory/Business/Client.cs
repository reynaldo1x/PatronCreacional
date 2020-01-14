using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Windows: Testing client code with the first factory type...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Mac: Testing the same client code with the second factory type...");
            ClientMethod(new MacFactory());

            Console.ReadLine();
        }

        public void ClientMethod(IGuiFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckBox();

            Console.WriteLine(productB.CreateCheckBox());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
