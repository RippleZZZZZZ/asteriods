using asteriods.src;
using asteriods.src.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace asteriods
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static int windowWidth = 975;
        public static int windowHeight = 975;

        Player player = new Player();
        Bullet bullet = new Bullet();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = windowWidth;
            _graphics.PreferredBackBufferHeight = windowHeight;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here


            try
            {
                foreach (var entity in Entity.entities)
                {
                    entity.Load(Content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            IsFixedTimeStep = false;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            //foreach(var bullet in Entity.bullets)
            {
                bullet.Update(deltaTime);
            }

            player.Update(deltaTime);
            Controller.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin(samplerState: SamplerState.PointClamp, blendState: BlendState.NonPremultiplied);


            try
            {
                foreach (var entity in Entity.entities)
                {
                    entity.Draw(_spriteBatch);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
