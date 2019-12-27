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

        public static bool operator == (Point first, Point second)
        {
            return first.XPos == second.XPos && first.YPos == second.YPos;
        }

        public static bool operator != (Point first, Point second)
        {
            return first.XPos != second.XPos && first.YPos != second.YPos;
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
