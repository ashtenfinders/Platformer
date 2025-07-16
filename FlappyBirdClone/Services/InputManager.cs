using FlappyBirdClone.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Services
{
    /**
     * Note: This manager currently only works for the keyboard!
     */
    public class InputManager : GameComponent
    {

        private Player _player;


        

        public InputManager(Game game, Player player) : base(game)
        {
            _player = player;
        }

        

        /**
         * Might want to change how this works!! Modularize it better etc. But this is the proper movement logic!!
         * 
         */
        public override void Update(GameTime gameTime)
        {

            _player.Direction = Vector2.Zero;
            //Delta time ensures smooth movement regardless of framerate
            //If not for delta time there would be a jump from 0 - speed!
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            var keyboardState = Keyboard.GetState();
            /*
            if (keyboardState.IsKeyDown(Keys.W))
            {
                _player.Direction += MovementDirection.Up;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                _player.Direction += MovementDirection.Down;
            }
            */
            if (keyboardState.IsKeyDown(Keys.A))
            {
                _player.Direction += MovementDirection.Left;

            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                _player.Direction += MovementDirection.Right;
            }
            if (keyboardState.IsKeyDown(Keys.Space) && _player.InAir == false)
            {
                _player.InAir = true;
                _player.Jump(dt);
            }
            if (_player.InAir == true)
            {
                _player.Velocity += new Vector2(0, _player.Gravity * dt);
                _player.Position += _player.Velocity * dt;
            }

            
            if (_player.Direction != Vector2.Zero)
            {
                //Normalize diagonal movement so that it is the same speed!!
                _player.Direction = Vector2.Normalize(_player.Direction);


                _player.Position += _player.Direction * _player.Speed *dt;
            }


            //Note: Draw is based off of position so the direction needs to affect the position

            base.Update(gameTime);
        }



    }
}
