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
        public string textureID;

        public static List<Entity> entities = new List<Entity>();

        public Entity()
        {
            entities.Add(this);
        }
        
        public Rectangle Rect
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32);  }
        }

        protected virtual void Movement(float deltaTime)
        {

        }
        public virtual void Update(float deltaTime)
        {

        }

        protected void Bounds()
        {
            if (position.X < -75) position.X = Game1.windowWidth + 75;
            if (position.Y < -75) position.Y = Game1.windowHeight + 75;
            if (position.X > Game1.windowWidth + 75) position.X = -75;
            if (position.Y > Game1.windowHeight + 75) position.Y = -75;
        }

        // loading and drawing
        public void Load(ContentManager Content)
        {
            texture = Content.Load<Texture2D>(textureID);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
}
