using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{

    public class Gaz51: Vehicle
    {

        private const int _numOfWeels = 6;
        private const int _odometer = 11000;
        private const double _size = 3.5;

        private const string _fuelType = "Diesel";
        private const int _tankCapacity = 100;

        private const double _curPres = 2.5;
        private const double _minPres = 2;
        private const double _maxPres = 3;

        //constructor
        public Gaz51()
                        : base(
                            _curPres, 
                            _minPres, 
                            _maxPres,
                            _numOfWeels,
                            _fuelType,
                            _tankCapacity,
                            _odometer,
                            _size)
        {
            

        }

        
       
    }
}
