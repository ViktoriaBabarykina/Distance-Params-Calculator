using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceParamsCalculator.Exceptions
{
    class MultyEmptyTextBoxException : DistanceParamsCalculatorEcxeption
    {
        public List<Label> EmptyTextBoxLabels { get; set; }

        public MultyEmptyTextBoxException(List<Label> emptyTextBoxLabels, string message = "") 
            : this(message)
        {
            EmptyTextBoxLabels = emptyTextBoxLabels;
        }

        public MultyEmptyTextBoxException()
        {

        }

        public MultyEmptyTextBoxException(string message, Exception innerException) 
            : base(message, innerException)
        {

        }
        public MultyEmptyTextBoxException(string message) 
            : base(message)
        {

        }
    }
}
