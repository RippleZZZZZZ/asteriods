using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace asteriods.src
{
    internal class Controller
    {
        public static bool W, A, S, D, Space;

        public static void KeyListener()
        {
            var keystate = Keyboard.GetState();

            if (keystate.IsKeyDown(Keys.W)) W = true;
            if (keystate.IsKeyDown(Keys.A)) A = true;
            if (keystate.IsKeyDown(Keys.S)) S = true;
            if (keystate.IsKeyDown(Keys.D)) D = true;
            if (keystate.IsKeyDown(Keys.E)) Space = true;

            if (keystate.IsKeyUp(Keys.W)) W = false;
            if (keystate.IsKeyUp(Keys.A)) A = false;
            if (keystate.IsKeyUp(Keys.S)) S = false;
            if (keystate.IsKeyUp(Keys.D)) D = false;
            if (keystate.IsKeyUp(Keys.E)) Space = false;
        }

        public static void Update()
        {
            KeyListener();
        }
    }
}
