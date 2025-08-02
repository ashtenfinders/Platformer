using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerCore.Contracts
{
    public interface IRenderable
    {
        public int Depth { get; set; }

        public void Render(SpriteBatch spriteBatch);

    }

    public enum WhichLayer
    {
        Background, Game, Foreground, UI
    }

}
