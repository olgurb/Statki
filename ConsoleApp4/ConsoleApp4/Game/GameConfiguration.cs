using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Game
{
    public static class GameConfiguration
    {
        public static List<ShipConfig> ShipConfig { get; } = new List<ShipConfig>() {
            new ShipConfig(NumberOfShipsWithFiveLifes, 5), new ShipConfig(NumberOfShipsWithFourLifes, 4), new ShipConfig(NumberOfShipsWithThreeLifes, 3),
            new ShipConfig(NumberOfShipsWithTwoLifes,2) };
        public static readonly int FieldSize = 10; // increase/decrease if you want to get the game spicy ;)
        public static readonly int NumberOfShipsWithFiveLifes = 1;
        public static readonly int NumberOfShipsWithFourLifes = 2;
        public static readonly int NumberOfShipsWithThreeLifes = 3;
        public static readonly int NumberOfShipsWithTwoLifes = 4;
    }
}
