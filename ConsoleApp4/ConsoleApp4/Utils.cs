using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;

namespace ConsoleApp4.Utilities
{
    public static class Utils
    {
        public static bool IsIntegerInRange(int value, int firstLimit, int secondLimit)
        {
            if (firstLimit == secondLimit)
                return value == firstLimit;
            if (firstLimit < secondLimit)
                return value >= firstLimit && value <= secondLimit;
            else
                return value <= firstLimit && value >= secondLimit;
        }

        public static int LinearFunctionValue(int parameter, Point firstPoint, Point secondPoint)
        {
            return (firstPoint.YPos - secondPoint.YPos) / (firstPoint.XPos - secondPoint.XPos) * parameter +
                firstPoint.YPos - (firstPoint.YPos - secondPoint.YPos) / (firstPoint.XPos - secondPoint.XPos)
                * firstPoint.XPos;
        }
    }
}
