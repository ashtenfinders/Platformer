using Microsoft.Xna.Framework;
using Platformer.Entities;
using Platformer.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Services
{
    public class CollisionManager : GameComponent
    {

        private Player _player;
        private Platform _platform;

        public CollisionManager(Game game, Player player, Platform platform) : base(game)
        {
            _player = player;
            _platform = platform;
        }




        public override void Update(GameTime gameTime)
        {


            if (_player.CollisionBox.Intersects(_platform.CollisionBox))
            {
                _player.InAir = false;

            }


            base.Update(gameTime);
        }
    }
}
