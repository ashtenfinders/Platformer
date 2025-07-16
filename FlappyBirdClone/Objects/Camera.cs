using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Objects
{
    public class Camera
    {

        /// <summary>
        /// <Property> The position of the camera
        /// </summary>
        public Vector2 Position { get; set; }

        public float Zoom { get; set; } = 1f;

        public float Rotation { get; set; } = 0f;


        private Game _game; 

        public Camera(Game game)
        {
            _game = game;

        }

        public Matrix GetTranslationMatrix()
        {
            Vector2 screenCenter = new Vector2(_game.GraphicsDevice.Viewport.Width * .5f, _game.GraphicsDevice.Viewport.Height * .5f);
            var deadZoneLeft = new Vector2(screenCenter.X - 300, screenCenter.Y);
            return Matrix.CreateTranslation(-Position.X, -Position.Y, 0) *
            Matrix.CreateRotationZ(Rotation) *
            Matrix.CreateScale(Zoom) *
            Matrix.CreateTranslation(deadZoneLeft.X, deadZoneLeft.Y, 0);
            //Matrix.CreateTranslation(screenCenter.X, screenCenter.Y, 0);
            
        }
    }
}
