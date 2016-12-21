using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //return true if the player wins, false otherwise.
        public bool Play()
        {
            //Run until all invaders are gone or one reaches the end of the path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //Each tower has a chance to shoot at invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //count and move invaders still alive
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }

            }
            return true;
        }

    }
}
