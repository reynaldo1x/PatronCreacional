using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteWinDialog.");
            ClientCode(new ConcreteWinDialog());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteWebDialog.");
            ClientCode(new ConcreteWebDialog());

            Console.ReadLine();
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }
}
