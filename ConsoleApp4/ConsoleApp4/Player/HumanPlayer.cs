﻿using System;
using System.Linq;
using Console.Point;
using ConsoleApp4.ShipUrb;
using ConsoleApp4.Game;

namespace ConsoleApp4.Player
{
    class HumanPlayer : PlayerBase
    {

        public HumanPlayer(string name, string victoryCry) : base(name, victoryCry) { }

        public override Point MakeMove()
        {
            System.Console.WriteLine("Dear Player {0}, please input x and y for you shoot ;)", Name);
            var input = System.Console.ReadLine();
            return GetPointFromString(input);
        }

        public override void SetupShips()
        {
        }

        protected override Ship CreateShipWithgivenLifes(ShipConfig)
        {
            return Ships.First();
        }

        private Point GetPointFromString(string inputString)
        {
            string[] separatingOperators = { " ", "," };
            var pointsAsString = inputString.Split(separatingOperators, System.StringSplitOptions.RemoveEmptyEntries);
            if (pointsAsString.Length != 2)
                throw new Exception("at least you could input the point correctly....");
            return new Point(Int32.Parse(pointsAsString[0]), Int32.Parse(pointsAsString[1]));
        }
    }
}
