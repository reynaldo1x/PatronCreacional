using System;
using Builder.Business;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new Car();//In this case, the builder it's the type of object. Example car object or car manual object
            director.Builder = builder;

            var director2 = new Director();
            var manual = new Manual();
            director2.Builder = manual;
            

            Console.WriteLine("Standard basic product:");
            director.SimpleCar();
            Console.WriteLine(builder.GetCar().ListParts());
            Console.WriteLine("Manual product:");
            director2.SimpleCarManual();
            Console.WriteLine(manual.GetManual().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.MakeSportCar();
            Console.WriteLine(builder.GetCar().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.ResetCar();
            builder.SetEngine();
            Console.Write(builder.GetCar().ListParts());

            Console.ReadLine();
        }
    }
}
