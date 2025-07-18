using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Platformer.Environment.Layer;

namespace Platformer.Environment
{
    public class ForegroundLayer : Layer
    {

        public ForegroundLayer()
        {
            Depth = DepthValues[(int)Depths.Foreground];
        }
    }
}
