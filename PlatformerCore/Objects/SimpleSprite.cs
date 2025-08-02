using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerCore.Objects
{

    /// <summary>
    /// A simple sprite, with a placeholder texture, used to render rectangle sprites for programmer art. 
    /// </summary>
    public class SimpleSprite : Sprite
    {


        public Rectangle DestinationRectangle { get; set; } 

        public SimpleSprite(Vector2 position, int width, int height)
        {
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public SimpleSprite(Rectangle rectangle)
        {
            DestinationRectangle = rectangle;
        }




        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(Texture, DestinationRectangle, null, Color, Rotation, Origin, Effects, LayerDepth);

        }

    }
}
