using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlappyBirdClone.Environment.Layer;

namespace FlappyBirdClone.Environment
{
    public class ForegroundLayer : Layer
    {

        public ForegroundLayer()
        {
            Depth = DepthValues[(int)Depths.Foreground];
        }
    }
}
