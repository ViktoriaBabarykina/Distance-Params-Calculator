using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceParamsCalculator.Exceptions
{
    class NoEmptyTextBoxException 
        : DistanceParamsCalculatorEcxeption
    {
        public NoEmptyTextBoxException()
        {

        }

        public NoEmptyTextBoxException(string message, Exception innerException) 
           : base(message, innerException)
        {

        }
        public NoEmptyTextBoxException(string message) 
            : base(message)
        {

        }
    }
}
