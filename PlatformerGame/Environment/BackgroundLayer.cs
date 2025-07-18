using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerGame.Environment
{
    /// <summary>
    /// Might need to update this so that i can have elements in the layer move at different speeds
    /// </summary>
    public class BackgroundLayer : Layer
    {
        //I think only background layers need parrallax scrolling
        public float Speed { get; set; } = 1f;

        public BackgroundLayer()        {
            Depth = DepthValues[(int)Depths.Background];
        }

        


    }
}
