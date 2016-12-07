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
            Tower tower = new Tower();
            Map map = new Map(8, 5);
           
            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}
