using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor.Services
{
    public class InputManager : GameComponent
    {
        public event Action<Vector2, float> OnWASD;

        private readonly Vector2[] _directions = [new Vector2(-1,0), new Vector2(1,0), new Vector2(0,-1), new Vector2(0,1)];
        private enum _direction
        {
            Left, Right, Up, Down
        }

        public InputManager(Game game) : base(game)
        {


        }


        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.A))
            {
                OnWASD?.Invoke(_directions[(int)_direction.Left], dt);
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                OnWASD?.Invoke(_directions[(int)_direction.Right], dt);
            }
            if (keyboardState.IsKeyDown(Keys.W))
            {
                OnWASD?.Invoke(_directions[(int)_direction.Up], dt);
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                OnWASD?.Invoke(_directions[(int)_direction.Down], dt);
            }

            base.Update(gameTime);
        }

       
    }
}
