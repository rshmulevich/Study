using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public interface ICar
    {
        int NumberOfWeels { get;  }
        Engine Engine { get; }
        int OdometerReading {get;}
        void FillTank(string fuelType, int liters);
        Wheel[] Wheels { get; }
        void Drive();

    }
}
