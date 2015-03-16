using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Engine
    {
        private double _size;


        //constructor
        public Engine(double size)
        {
            _size = size;
        }

        // Property implementation: 
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public void Start()
        { 
        }

    }
}
