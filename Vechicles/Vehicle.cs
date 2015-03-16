using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechicles;

namespace Study
{
    

    public abstract class Vehicle:ICar
    {
        private int _numOfWeels;
        private Engine _oEngine;
        private Wheel[] _oWheels;

        private string _fuelType;
        private int _tankCapacity;

               
        //constructor
        public Vehicle( double pressure, 
                        double minPressure, 
                        double maxPressure,  
                        int numOfWeels,
                        string fuelType,
                        int tankCapacity,
                        int odometer,
                        double size)
        {
            _numOfWeels = numOfWeels;
            _fuelType = fuelType;
            _tankCapacity = tankCapacity;
            OdometerReading = odometer;

            _oEngine = new Engine(size);


            _oWheels = new Wheel[_numOfWeels];
            for (int n = 0; n < _numOfWeels; n++)
            {
                _oWheels[n] = new Wheel(pressure, minPressure, maxPressure);
            }


            //var results = _oWheels.Select(
            //    w =>
            //    { 
            //        return w.CheckPressure(); 
            //    }); //LINQ way

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

        }

        // Property implementation: 
        public int NumberOfWeels
        {
            get { return _numOfWeels; }
        }

        public Engine Engine
        {
            get
            {
                return _oEngine;
            }
        }

        public int OdometerReading { get; private set; }
        

        public void FillTank(string fuelType, int liters)
        {
                       
            if (fuelType != _fuelType)
            { 
                
                throw new WrongFuelTypeException(string.Format("Wrong fuel, you can use only {0} on this vehicle", _fuelType));
                //throw new System.ArgumentOutOfRangeException(string.Format("Wrong fuel, you can use only {0} on this vehicle", _fuelType));
            }
            if (liters > _tankCapacity) 
            {
                throw new WrongFuelAmountException(string.Format("You can't fill more than {0} ltrs in this vehicle", _tankCapacity));
                //throw new System.ArgumentOutOfRangeException(string.Format("You can't fill more than {0} ltrs in this vehicle", _tankCapacity));
            }
            
        }

        public Wheel[] Wheels
        {
            get
            {
                return _oWheels;
            }
        }

        

        

        
        public void Drive()
        {
            OdometerReading += 100;
        }

    }
}
