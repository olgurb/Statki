using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;
using ConsoleApp4.ShipUrb;

namespace ConsoleApp4.Game
{
    public class GameBoard
    {
        public BoardPoint[,] Points { get; private set; }
        
        public GameBoard()
        {
            Points = new BoardPoint[GameConfiguration.FieldSize, GameConfiguration.FieldSize];
            var length = Points.Length / 2;
            for(int i = 0; i<length; i++)
            {
                for(int j = 0; j<length; j++)
                {
                    Points[i, j] = new BoardPoint(i + 1, j + 1);
                }
            }
        }
        public void MarkShipOnBoard(Ship ship)
        {
            var points = ship.GetAllPointsOfShip();
            foreach (var boardPoint in Points)
            {
                boardPoint.HasShip = points.ToList().Any(p => p.XPos == boardPoint.XPos && p.YPos == boardPoint.YPos);
            }
        }
        public void MarkShipsOnBoard(List<Ship> ships)
        {
            ships.ForEach(s => MarkShipOnBoard(s));
        }
    }
}
