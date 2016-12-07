using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class SpaceInvaders : AbstractGame
    {
        private Player player;
        private Enemy enemy;
        public override void GameStart()
        {
            player = new Player();
            enemy = new Enemy();
        }

        public override void GameEnd()
        {
            
        }

        public override void Update()
        {
            player.Update();
        }

        public override void Paint()
        {
            player.Paint();
        }
    }
}
