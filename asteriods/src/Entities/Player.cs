using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace asteriods.src.Entities
{
    internal class Player : Entity
    {
        float speed = 0f;
        public float angle = -1.55555f;
        Vector2 origin;
        public Player() : base()
        {
            position = new Vector2((Game1.windowWidth / 2 ) - (64 / 2), (Game1.windowHeight / 2) - (64 / 2));
            textureID = "aShip";
            origin = new Vector2(64 / 2, 64 / 2);
        }

        protected override void Movement(float deltaTime)
        {
            Vector2 velocity = Vector2.Zero; // 

            if(!Controller.W) if (speed >= 0f) speed -= 250.00f * deltaTime / 2; if (speed < 0f) speed = 0f;

            if (Controller.W) if (speed < 500f) speed += 450f * deltaTime / 2;

            if (Controller.Space) Entity.bullets.Add(new Bullet());

            velocity.X = (float)Math.Cos(angle) * speed;
            velocity.Y = (float)Math.Sin(angle) * speed;

            Debug.WriteLine(angle);
            position += velocity * deltaTime;
        }

        private void Rotate(float deltaTime)
        {
            if (Controller.D)
            {
                angle += 2.0f * deltaTime;
                if (angle > 0) speed -= (angle * 2.5f) * deltaTime;
                if (angle < 0) speed += (angle * 2.5f) * deltaTime;
            }
            if (Controller.A)
            {
                angle -= 2.0f * deltaTime;
                if (angle > 0) speed -= (angle * 2.5f) * deltaTime;
                if (angle < 0) speed += (angle * 2.5f) * deltaTime;
            }

            float circle = MathHelper.Pi * 2;

            angle %= circle;
        }

        public override void Update(float deltaTime)
        {
            Movement(deltaTime);
            Rotate(deltaTime);
            Bounds();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, angle, origin, 1.0f, SpriteEffects.None, 0f);
        }
    }
}
