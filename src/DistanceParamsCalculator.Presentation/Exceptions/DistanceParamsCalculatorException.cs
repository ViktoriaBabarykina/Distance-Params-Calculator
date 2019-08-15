using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceParamsCalculator.Exceptions
{
    public class DistanceParamsCalculatorEcxeption : Exception
    {
        public DistanceParamsCalculatorEcxeption()
        {

        }

        public DistanceParamsCalculatorEcxeption(string message, Exception innerException) 
            : base(message, innerException)
        {

        }
        public DistanceParamsCalculatorEcxeption(string message) 
            : base(message)
        {

        }
    }
 }
