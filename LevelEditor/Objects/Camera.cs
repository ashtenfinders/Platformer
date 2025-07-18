using LevelEditor.Services;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor.Objects
{
    public class Camera
    {


        /// <summary>
        /// <Property> The position of the camera
        /// </summary>
        public Vector2 Position { get; set; }
        public float Speed { get; set; } = 500f;

        public float Zoom { get; set; } = 1f;

        private readonly Game _game;

        private readonly InputManager _inputManager;


        public Camera(Game game, InputManager inputManager)
        {
            _game = game;
            _inputManager = inputManager;
            Position = new Vector2(0,0);

        }

        public Matrix GetTranslationMatrix()
        {
            Vector2 screenCenter = new Vector2(_game.GraphicsDevice.Viewport.Width * .5f, _game.GraphicsDevice.Viewport.Height * .5f);

            return Matrix.CreateTranslation(-Position.X, -Position.Y, 0) *
            //Matrix.CreateRotationZ(Rotation) *
            Matrix.CreateScale(Zoom) *
            Matrix.CreateTranslation(screenCenter.X, screenCenter.Y, 0);
            //Matrix.CreateTranslation(screenCenter.X, screenCenter.Y, 0);

        }
        public void RegisterEvents()
        {
            _inputManager.OnWASD += Move;
        }

        public void Move(Vector2 direction, float deltaTime)
        {
            Position += deltaTime * Speed * direction;
        }
    }
}
