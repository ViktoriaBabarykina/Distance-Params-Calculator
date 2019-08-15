using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceParamsCalculator.Math.Converters
{
    static public class DegreeToRadConverter
    {
        public static double Convert(double degree)
        {
            return degree * System.Math.PI / 180;
        }

        public static double ConvertBack(double rad)
        {
            return rad * 180 / System.Math.PI ;
        }
    }
}
