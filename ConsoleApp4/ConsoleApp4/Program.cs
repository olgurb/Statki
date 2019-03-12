using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Point;
using ConsoleApp4.Utilities;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = 123;
            var point1 = new Point(1, 2);
            var point2 = new Point(10, 20);
            System.Console.WriteLine(Utils.LinearFunctionValue(param, point2, point1));
            System.Console.ReadKey();
        }
    }
}
