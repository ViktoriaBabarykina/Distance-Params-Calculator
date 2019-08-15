using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceParamsCalculator.Exceptions
{
    class IncorrectInputException : DistanceParamsCalculatorEcxeption
    {
        public List<Label> IncorrectInputLabels { get; set; }

        public IncorrectInputException(List<Label> incorrectInputLabels, string message = "")
            : this(message)
        {
            IncorrectInputLabels = incorrectInputLabels;
        }

        public IncorrectInputException()
        {

        }

        public IncorrectInputException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        public IncorrectInputException(string message)
            : base(message)
        {

        }
    }
}
