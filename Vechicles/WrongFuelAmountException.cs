using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechicles
{
    public class WrongFuelAmountException : Exception
    {
        public WrongFuelAmountException(string message)
            : base(message)
        {

        }
    }
}
