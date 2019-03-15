using System.Collections.Generic;
using Console.Point;
using ConsoleApp4.ShipUrb;
using ConsoleApp4.Game;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Player
{
    public abstract class PlayerBase
    {
        public string Name { get; private set; }
        public string VictoryCry { get; private set; }
        protected List<Point> CheckedPoints { get; set; }
        protected List<Ship> Ships { get; set; }

        public PlayerBase(string name, string victoryCry)
        {
            if (string.IsNullOrEmpty(name))
                Name = "Mysterious Challenger";
            else
                Name = name;
            if (string.IsNullOrEmpty(victoryCry))
                VictoryCry = "Meh no victory cry for that one...";
            CheckedPoints = new List<Point>();
            Ships = new List<Ship>();
        }
        public abstract void SetupShips();
        public abstract Point MakeMove();
        protected abstract Ship CreateShipWithgivenLifes(ShipConfig shipConfig);
        protected bool CheckIfShipLocationIsValid(Ship ship)
        {
            return Ships.Any(s => ship.CheckIfColidesWithAnotherShip(s));
        }
    }
}
