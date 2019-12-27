using System;
using Console.Point;
namespace Console.Point
{
    public class BoardPoint : Point
    {
        public bool Shooted { get; set; }
        public bool HasShip { get; set; }
        public BoardPoint(int xPos, int yPos) : base(xPos, yPos)
        {
            Shooted = false;
            HasShip = false;
        }
    }
}
