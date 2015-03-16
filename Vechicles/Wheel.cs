using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Wheel
    {
        private double _pressure;
        private double _minPressure;
        private double _maxPressure;

        //constructor
        public Wheel(double pressure, double minPressure, double maxPressure)
        {
            _pressure = pressure;
            _minPressure = minPressure;
            _maxPressure = maxPressure;
        }



        public int CheckPressure()
        {
            return _maxPressure.CompareTo(_pressure);

            //if (_maxPressure < _pressure) 
            //{ 
            //    return 1; 
            //}

            //else if (_pressure < _minPressure) 
            //{ 
            //    return -1; 
            //}
            //else 
            //    return 0;
        }
    }
}
