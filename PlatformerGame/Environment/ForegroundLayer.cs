using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlatformerGame.Environment.Layer;

namespace PlatformerGame.Environment
{
    public class ForegroundLayer : Layer
    {

        public ForegroundLayer()
        {
            Depth = DepthValues[(int)Depths.Foreground];
        }
    }
}
