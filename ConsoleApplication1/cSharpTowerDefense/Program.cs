using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTowerDefense
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
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (DefenseException)
            {
                Console.WriteLine("Unhandled DefenseExceptions");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
            
        }
    }
}
