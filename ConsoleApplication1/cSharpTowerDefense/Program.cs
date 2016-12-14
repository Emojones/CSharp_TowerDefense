using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpTowerDefense;

namespace csharpTowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
           
            Map map = new Map(8, 5);

            try
            {
                MapLocation maplocation = new MapLocation(20, 20, map);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
