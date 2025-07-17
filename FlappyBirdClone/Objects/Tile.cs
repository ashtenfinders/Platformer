using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Objects
{
    public class Tile
    {
        //64 x 60 dimensions for screen tile map requires these dimensions for the tile size
        public static int Width { get; set; } = 30;
        public static int Height { get; set; } = 16;
        public Rectangle BoundingBox { get; set; }

        //Whether or not the player can pass through this tile
        public bool IsPassable { get; set; } = false;

        public Tile (Point point)
        {
            BoundingBox = new Rectangle(point.X * Width, point.Y *Height,  Width, Height);
        }
    }
}
