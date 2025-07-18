
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Environment
{
    public class Platform
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; } = Vector2.Zero;

        public Rectangle CollisionBox { get; }

        public Platform()
        {
            CollisionBox = new Rectangle(0, Game1.screenHeight - 50, Game1.screenWidth, 50);
        }

    }
}
