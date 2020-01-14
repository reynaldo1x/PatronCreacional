using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void SimpleCar()
        {
            this._builder.ResetCar();
        }

        public void SimpleCarManual()
        {
            this._builder.ResetCar();
        }

        public void MakeSportCar()
        {
            this._builder.ResetCar();
            this._builder.SetSeats();
            this._builder.SetEngine();
            this._builder.SetTripComputer();
            this._builder.SetGPS();
        }
    }
}
