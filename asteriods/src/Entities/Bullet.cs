using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;

namespace asteriods.src.Entities
{
    internal class Bullet : Entity
    {
        float speed = 500f;
        float angle;
        public Bullet() : base()
        {
            position = new Vector2(0f, 0f);
            textureID = "test";
            scale = 16;
            Entity.bullets.Add(this);
        }

        protected override void Movement(float deltaTime)
        {
            Vector2 velocity = Vector2.Zero;

            velocity.X = (float)Math.Cos(angle) * speed;
            velocity.Y = (float)Math.Sin(angle) * speed;

            position += velocity * deltaTime;
        }

        public void Tracking(float angle, Vector2 playerPos)
        {
            this.angle = angle;
            position.X = playerPos.X - (Rect.Width / 2);
            position.Y = playerPos.Y - (Rect.Height / 2);
            position.X += 25 * (float)Math.Cos(this.angle);
            position.Y += 25 * (float)Math.Sin(this.angle);
        }

        public override void Update(float deltaTime)
        {
            Movement(deltaTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
