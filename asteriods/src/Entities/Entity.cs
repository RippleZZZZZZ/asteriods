using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace asteriods.src.Entities
{
    internal class Entity
    {
        public Vector2 position;
        public Texture2D texture;
        public Texture2D hitbox;
        public string textureID;
        public string hitboxID = "test";
        public int scale;

        public static List<Entity> entities = new List<Entity>();
        public static List<Bullet> bullets = new List<Bullet>();

        public Entity()
        {
            entities.Add(this);
        }
        
        public Rectangle Hitbox
        {
            get { return new Rectangle((int)position.X - (scale / 2), (int)position.Y - (scale / 2), scale, scale);  }
        }

        protected virtual void Movement(float deltaTime)
        {

        }
        public virtual void Update(float deltaTime)
        {

        }

        protected void Bounds()
        {
            if (position.X < -50) position.X = Game1.windowWidth + 50;
            if (position.Y < -50) position.Y = Game1.windowHeight + 50;
            if (position.X > Game1.windowWidth + 50) position.X = -50;
            if (position.Y > Game1.windowHeight + 50) position.Y = -50;
        }

        // loading and drawing
        public void Load(ContentManager Content)
        {
            hitbox = Content.Load<Texture2D>(hitboxID);
            texture = Content.Load<Texture2D>(textureID);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (Controller.H) spriteBatch.Draw(hitbox, Hitbox, Color.White);
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
