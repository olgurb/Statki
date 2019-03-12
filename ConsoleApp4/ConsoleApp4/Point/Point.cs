using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Utilities;

namespace Console.Point
{
    public class Point
    {
        public int XPos { get; set; }
        public int YPos { get; set; }

        public Point(int x,int y) {
            XPos = x;
            YPos = y;
        }

        public bool CheckIfInRange(Point startPoint, Point endPoint)
        {
            if (!Utils.IsIntegerInRange(XPos, startPoint.XPos, endPoint.XPos)
                || !Utils.IsIntegerInRange(YPos, startPoint.YPos, endPoint.YPos))
                return false;
            return true;
        }

    }
}
