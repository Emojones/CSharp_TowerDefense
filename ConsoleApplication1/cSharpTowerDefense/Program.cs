using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
           
            Map map = new Map(8, 5);
            Point point = new Point(4, 2);
            Console.WriteLine(point.DistanceTo(5, 5));

            bool isOnMap = map.OnMap(point);
            int area = map.Width * map.Height;
            Console.WriteLine(area);
            Console.WriteLine(isOnMap);
        }
    }
}
