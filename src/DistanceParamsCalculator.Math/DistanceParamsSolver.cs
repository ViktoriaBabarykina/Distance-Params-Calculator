using DistanceParamsCalculator.Math.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceParamsCalculator.Math
{
    public sealed class DistanceParamsSolver
    {        
        public double FindPixelSize(double linearSize,
            double horisontalSizeInPixels,
            double distance,
            double horisontalFieldOfView)
        {
            double pixelSize;
            horisontalFieldOfView = DegreeToRadConverter.Convert(horisontalFieldOfView);
            pixelSize = (linearSize * horisontalSizeInPixels) /
                (2 * distance * System.Math.Tan(horisontalFieldOfView / 2));
            return pixelSize;
        }

        public double FindLinearSize(double pixelSize,
            double horisontalSizeInPixels,
            double distance,
            double horisontalFieldOfView)
        {
            double linearSize;
            horisontalFieldOfView = DegreeToRadConverter.Convert(horisontalFieldOfView);
            linearSize = (pixelSize * 2 * distance * System.Math.Tan(horisontalFieldOfView / 2)) 
                / horisontalSizeInPixels;
            return linearSize;
        }

        public double FindHorisontalSizeInPixels(double pixelSize,
            double linearSize,
            double distance,
            double horisontalFieldOfView)
        {
            double horisontalSizeInPixels;
            horisontalFieldOfView = DegreeToRadConverter.Convert(horisontalFieldOfView);
            horisontalSizeInPixels = (pixelSize * 2 * distance * System.Math.Tan(horisontalFieldOfView / 2)) 
                / linearSize;
            return horisontalSizeInPixels;
        }

        public double FindDistance(double pixelSize,
            double linearSize,
            double horisontalSizeInPixels,
            double horisontalFieldOfView)
        {
            double distance;
            horisontalFieldOfView = DegreeToRadConverter.Convert(horisontalFieldOfView);
            distance = (linearSize * horisontalSizeInPixels) 
                / (2 * pixelSize * System.Math.Tan(horisontalFieldOfView / 2));
            return distance;
        }

        public double FindHorisontalFieldOfView(double pixelSize,
            double linearSize,
            double horisontalSizeInPixels,
            double distance)
        {
            double horisontalFieldOfView;
            horisontalFieldOfView = 2 * System.Math.Atan((linearSize * horisontalSizeInPixels) / 2 * distance * pixelSize);
            return DegreeToRadConverter.ConvertBack(horisontalFieldOfView);
        }        
    }
}
