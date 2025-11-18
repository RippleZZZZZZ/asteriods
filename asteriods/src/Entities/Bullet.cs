using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace asteriods.src.Entities
{
    internal class Bullet : Entity
    {
        float speed = 500f;
        public Bullet() : base()
        {
            textureID = "aBullet";
            bullets.Add(this);
        }

        protected override void Movement(float deltaTime)
        {
            Vector2 velocity = Vector2.Zero;

            foreach(var bullet in Entity.bullets)
            {
                velocity.X = (float)Math.Cos(Player.angle) * speed;
                velocity.Y = (float)Math.Sin(Player.angle) * speed;
            }

            position += velocity * deltaTime;
        }

        public void Update(float deltaTime)
        {
            Movement(deltaTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
