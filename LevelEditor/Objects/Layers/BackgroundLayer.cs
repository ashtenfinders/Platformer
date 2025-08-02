using Microsoft.Xna.Framework;
using PlatformerCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor.Objects.Layers
{
    public class BackgroundLayer : DrawableGameComponent
    {
        
        public BackgroundLayer(Game game) : base(game)
        {
            DrawOrder = (int)WhichLayer.Background;
        }




        
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

    }
}
