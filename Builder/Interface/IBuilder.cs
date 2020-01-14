using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interface
{
    public interface IBuilder
    {
        void ResetCar();

        void SetSeats();

        void SetEngine();

        void SetTripComputer();

        void SetGPS();
    }
}
