using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Objects
{
    public class Tilemap
    {
        //Currently want the tilemap to be dynamic, if I reach a point where it is static
        //A 2d array is probably the better structure
        private Dictionary<Point, Tile> Tiles;

        public Tilemap()
        {
            Tiles = new Dictionary<Point, Tile>();
        }


        //Add interaction methods and factory methods



        public static Tilemap CreateTilemap()
        {
            var newTilemap = new Tilemap();
            //World map is two screens or 128x60 (64x60)
            for (int i =0; i < 128; i ++)
            {
                for (int j =0; j < 60; j ++)
                {
                    
                    
                    var point = new Point(i, j);
                    var tile = new Tile(point);
                    //Add the platform to the bottom row
                    if (j == 59)
                    {
                        tile.IsPassable = false;
                    }
                    newTilemap.AddTile(point, tile);

                }
                
            }

            return newTilemap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">
        /// The point in the TILEMAP (0,0) is the first tile in the tile map
        /// </param>
        /// <param name="tile"></param>
        public void AddTile(Point point, Tile tile)
        {
            Tiles.Add(point, tile);
        }
        public Tile GetTile(int x, int y)
        {
            return Tiles.GetValueOrDefault(new Point(x,y));
        }
        public Tile GetTileFromWorldPosition(Vector2 worldPosition)
        {
            
                return GetTile((int)worldPosition.X / Tile.Width,
                (int)worldPosition.Y / Tile.Height);
        }
    }
}
