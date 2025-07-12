using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Entities
{
    public class Player
    {

        //Vector 2 is like an x,y coordinate point, or just a data type with 2 numbers
        public Vector2 Position { get; set; } = Vector2.Zero;

        public Vector2 Direction { get; set; }

        public float Speed { get; set; } = 300;

        public Texture2D Texture { get; set; }

        

        public Player()
        {

        }


        public void Jump()
        {

        }

    }


    public static class MovementDirection
    {
        //Note: In mono game the y axis direction is flipped!
        public static Vector2 Down { get; } = new Vector2(0, 1);
        public static Vector2 Up { get; } = new Vector2(0,-1);
        public static Vector2 Right { get; } = new Vector2(1,0);
        public static Vector2 Left { get; } = new Vector2(-1, 0);


    }


}
