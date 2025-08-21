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
    public class SimpleSprite
    {
        /// <summary>
        /// Gets or Sets the source texture region represented by this sprite.
        /// </summary>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// Gets or Sets the color mask to apply when rendering this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is Color.White
        /// </remarks>
        public Color Color { get; set; } = Color.White;

        /// <summary>
        /// Gets or Sets the amount of rotation, in radians, to apply when rendering this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is 0.0f
        /// </remarks>
        public float Rotation { get; set; } = 0.0f;

        /// <summary>
        /// Gets or Sets the scale factor to apply to the x- and y-axes when rendering this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is Vector2.One
        /// </remarks>
        public Vector2 Scale { get; set; } = Vector2.One;

        /// <summary>
        /// Gets or Sets the xy-coordinate origin point, relative to the top-left corner, of this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is Vector2.Zero
        /// </remarks>
        public Vector2 Origin { get; set; } = Vector2.Zero;

        /// <summary>
        /// Gets or Sets the sprite effects to apply when rendering this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is SpriteEffects.None
        /// </remarks>
        public SpriteEffects Effects { get; set; } = SpriteEffects.None;

        /// <summary>
        /// Gets or Sets the layer depth to apply when rendering this sprite.
        /// </summary>
        /// <remarks>
        /// Default value is 0.0f
        /// </remarks>
        public float LayerDepth { get; set; } = 0.0f;

        /// <summary>
        /// Gets the width, in pixels, of this sprite. 
        /// </summary>
        /// <remarks>
        /// Width is calculated by multiplying the width of the source texture region by the x-axis scale factor.
        /// </remarks>
        public float Width => Texture.Width * Scale.X;

        /// <summary>
        /// Gets the height, in pixels, of this sprite.
        /// </summary>
        /// <remarks>
        /// Height is calculated by multiplying the height of the source texture region by the y-axis scale factor.
        /// </remarks>
        public float Height => Texture.Height * Scale.Y;

        /// <summary>
        /// The rectangle for this sprite 
        /// </summary>
        public Rectangle DestinationRectangle { get; set; } 

        public SimpleSprite(Vector2 position, int width, int height)
        {
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public SimpleSprite(Rectangle rectangle)
        {
            DestinationRectangle = rectangle;
        }




        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(Texture, DestinationRectangle, null, Color, Rotation, Origin, Effects, LayerDepth);

        }

    }
}
