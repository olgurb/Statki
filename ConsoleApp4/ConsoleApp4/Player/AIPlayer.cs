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
            throw new NotImplementedException();
        }

        public override void SetupShips()
        {
            throw new NotImplementedException();
        }

        protected override Ship CreateShipWithgivenLifes(ShipConfig shipConfig)
        {
            throw new NotImplementedException();
        }
    }
}
