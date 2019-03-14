using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Game
{
    public static class GameConfiguration
    {
        public static List<int> ShipConfig {
            get
            {
                // TODO: find a smarter way
                return new List<int>() {NumberOfShipsWithFiveLifes, NumberOfShipsWithFourLifes,
                NumberOfShipsWithThreeLifes, NumberOfShipsWithTwoLifes};
            }
        }
        public static readonly int FieldSize = 10; // increase/decrease if you want to get the game spicy ;)
        public static readonly int NumberOfShipsWithFiveLifes = 1;
        public static readonly int NumberOfShipsWithFourLifes = 2;
        public static readonly int NumberOfShipsWithThreeLifes = 3;
        public static readonly int NumberOfShipsWithTwoLifes = 4;
    }
}
