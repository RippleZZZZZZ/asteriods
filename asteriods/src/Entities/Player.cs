using Microsoft.Xna.Framework;

namespace asteriods.src.Entities
{
    internal class Player : Entity
    {
        public Player() : base()
        {
            position = new Vector2(100f, 100f);
            textureID = "test";
        }

        protected override void Movement(float deltaTime)
        {
            base.Movement(deltaTime);
        }

        protected override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}
