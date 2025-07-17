using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlappyBirdClone.Environment.Layer;

namespace FlappyBirdClone.Environment
{
    public class GameplayLayer : Layer
    {
        public GameplayLayer()
        {
            Depth = DepthValues[(int)Depths.Midground];
        }
    }
}
