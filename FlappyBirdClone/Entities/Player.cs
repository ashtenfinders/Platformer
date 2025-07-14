using FlappyBirdClone.Services;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone.Entities
{
    public class Player
    {

        //Vector 2 is like an x,y coordinate point, or just a data type with 2 numbers
        public Vector2 Position { get; set; } = Vector2.Zero;

        //For horizontal movement
        public Vector2 Direction { get; set; }

        //For vertical/jump
        //We want the jumps inital velocity to be something, and then gradually as
        //time in the air increases, gravity will start affecting this velocity so that eventually the velocity becomes
        //positive(negative) and the player drops back down. Only stopping once reaching the ground!

        //
        public Vector2 Velocity { get; set; } = Vector2.Zero;

        public float Gravity { get; } = 500;

        public float Speed { get; set; } = 300;

        public Texture2D Texture { get; set; }

        private readonly PhysicsManager _physics;

        public bool InAir { get; set; } = false;

        public Rectangle CollisionBox { get; set; } 


        public Player(Vector2 position)
        {
            Position = position;
            CollisionBox = new Rectangle((int)Position.X, (int)Position.Y, 50, 100);
        }

        /**
         * Move the from where they are currently positioned
         */
        public void Move(int x, int y)
        {
            Position += new Vector2(x, y);
        }

        public void Jump(float deltaTime)
        {
            // Jumpforce
            var velocity = Velocity;
            velocity.Y = -300;
            Velocity = velocity;
        }
    }

    /**
     * For horizontal movement
     */
    public static class MovementDirection
    {
        public static Vector2 Right { get; } = new Vector2(1,0);
        public static Vector2 Left { get; } = new Vector2(-1, 0);


    }


}
