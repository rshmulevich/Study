using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
  

    public class ToyotaVenza: Vehicle
    {
        private const int _numOfWeels = 4;
        private const int _odometer = 91000;
        private const double _size = 2.7;
        private const string _fuelType = "Gasolin";
        private const int _tankCapacity=60;

        private const double _curPres = 2.5;
        private const double _minPres = 2;
        private const double _maxPres = 3;
      
        //constructor
        public ToyotaVenza()
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
