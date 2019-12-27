using System;
using System.Collections.Generic;
using System.Linq;
using Console.Point;
using ConsoleApp4.Utilities;

namespace ConsoleApp4.ShipUrb
{

    public class Ship
    {
       private int Lifes { get; set; }
       private Point Start { get; set; }
       private Point End { get; set; }

        public bool isAlive {
            get
            {
                return Lifes > 0;
            }
        }       

       public Ship(Point start, Point end) {
            Start = start;
            End = end;
            if (start.XPos == end.XPos)
                Lifes = Math.Abs(end.YPos - start.YPos) + 1;
            else
                Lifes = Math.Abs(end.XPos - start.XPos) + 1; 
        }

        public bool CheckIfColidesWithAnotherShip(Ship ship)
        {
            // TODO: it should also check if there is any ship in the nearest neighbourhood
            var currentShipPoints = GetAllPointsOfShip();
            var inputShipPoints = ship.GetAllPointsOfShip();
            return currentShipPoints.Any(p => inputShipPoints.Any(ip => p == ip));
        } 

        public bool CheckIfShooted(Point shoot)
        {
            if (!shoot.CheckIfInRange(Start, End))
                return false;
            else if (shoot.YPos == Utils.LinearFunctionValue(shoot.XPos, Start, End))
            {
                ReduceLife();
                return true;
            }
            return false;
        }

        public IEnumerable<Point> GetAllPointsOfShip()
        {
            if (Start.YPos == End.YPos)
            {
                return Enumerable.Range(Math.Min(Start.XPos, End.XPos), Math.Abs(Start.XPos - End.XPos))
                    .Select(c => new Point(c, Start.YPos));
            }
            else
            {
                return Enumerable.Range(Math.Min(Start.YPos, End.YPos), Math.Abs(Start.YPos - End.YPos))
                    .Select(c => new Point(Start.XPos, c));
            }
        }
        private int ReduceLife() => --Lifes;
    }
}
