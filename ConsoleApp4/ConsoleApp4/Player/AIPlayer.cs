using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;    
using ConsoleApp4.Game;
using ConsoleApp4.ShipUrb;

namespace ConsoleApp4.Player
{
    public class AIPlayer : PlayerBase
    {
        public AIPlayer(): base("AI", "beep beep! I will destroy you!") { }

        public override Point MakeMove()
        {
            Point point;
            while (true) {
                point = GetRandomPoint();
                if (CheckedPoints.All(p => p != point))
                {
                    CheckedPoints.Add(point);
                    return point;
                }
            }
        }

        public override void SetupShips()
        {
            throw new NotImplementedException();
        }

        protected override Ship CreateShipWithgivenLifes(ShipConfig shipConfig)
        {
            throw new NotImplementedException();
        }

        private Point GetRandomPoint()
        {
            var boardLen = GameConfiguration.FieldSize;
            var random = new Random();
            var x = random.Next(1, boardLen);

            var y = random.Next(1, boardLen);


            return new Point(x,y);
        }
    }
}
