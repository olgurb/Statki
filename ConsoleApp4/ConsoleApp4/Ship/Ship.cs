using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;

namespace ConsoleApp4.Ship
{
    class Ship
    {
       private int lifes { get; set; }
       public Point Start { get; set; }
       public Point End { get; set; }

       

       public Ship(Point start, Point end) {
            Start = start;
            End = end;
            if (start.XPos == end.XPos)
            {
                lifes = Math.Abs(end.YPos - start.YPos) + 1;
            }
            else
                lifes = Math.Abs(end.XPos - start.XPos) + 1; 
        }
        public void ReduceLife()
        {
            lifes--;
        }

        public bool IsAlive()
        {
            return lifes > 0; 
        }

        public void CheckIfShooted(Point xy)
        {
            
        }

    }
}
