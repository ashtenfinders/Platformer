using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Environment
{
    public abstract class Layer
    {
        public float[] DepthValues { get; } = [1.0f, 0.5f, 0.0f];

        public Texture2D Texture { get; set; }

        public float Depth;
        public enum Depths
        {
            Background,
            Midground, 
            Foreground
        }
    }
}
