using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;
using ConsoleApp4.Utilities;

namespace ConsoleApp4.Ship
{
    class Ship
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
            {
                Lifes = Math.Abs(end.YPos - start.YPos) + 1;
            }
            else
                Lifes = Math.Abs(end.XPos - start.XPos) + 1; 
        }

        private int ReduceLife() => Lifes--;

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
    }
}
