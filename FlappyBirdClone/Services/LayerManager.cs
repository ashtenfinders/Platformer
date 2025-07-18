using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Platformer.Environment;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Services
{
    public class LayerManager : DrawableGameComponent
    {
        private List<Layer> _layers = new();
        private SpriteBatch _spriteBatch;

        public LayerManager(Game game, SpriteBatch spriteBatch) : base(game)
        {
            _spriteBatch = spriteBatch;
        }

        public void AddLayer(Layer layer)
        {
            _layers.Add(layer);
        }

        //Need to have an update here to handle updating the different layers. 
        //Start with updating the background layer

        public override void Draw(GameTime gameTime)
        {
            //For now, only three layers will ever be in the list
            foreach (var layer in _layers)
            {
                //Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)

                _spriteBatch.Begin(sortMode: SpriteSortMode.BackToFront);
                //_spriteBatch.Draw();
                Debug.WriteLine(layer.Depth);
                _spriteBatch.Draw(layer.Texture, new Rectangle(0,0,Game.GraphicsDevice.Viewport.Width, Game.GraphicsDevice.Viewport.Height ),null,Color.Blue, 0f, Vector2.Zero, SpriteEffects.None, layer.Depth);
                _spriteBatch.End();
                
            }
            base.Draw(gameTime);
        }

        

    }
}
