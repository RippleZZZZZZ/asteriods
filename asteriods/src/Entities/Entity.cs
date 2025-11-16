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
            get { return new Rectangle((int)position.X, (int)position.Y, 64, 64);  }
        }
        protected virtual void Movement(float deltaTime)
        {

        }
        protected virtual void Update(float deltaTime)
        {

        }

        // loading and drawing
        public void Load(ContentManager Content)
        {
            texture = Content.Load<Texture2D>(textureID);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
}
