using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Objects
{
    public class Level
    {
        /// <summary>
        /// Containter for a tile map belonging to a particular level
        /// Not sure if this class is nescessary or not
        /// </summary>
        public Tilemap Tilemap { get; set; }

        public Level(Tilemap tilemap)
        {
            Tilemap = tilemap;
        }

    }
}
