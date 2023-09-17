using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace summer2023StarDogMobyGreenNebulaRush
{
    class Player
    {
        public Vector2 position = new Vector2(100, 100);
        float movementSpeed = 180.0f;

        public void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D))
            {
                position.X += movementSpeed * deltaTime;
            }
            if (keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A))
            {
                position.X -= movementSpeed * deltaTime;
            }
            if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
            {
                position.Y -= movementSpeed * deltaTime;
            }
            if (keyboardState.IsKeyDown(Keys.Down) || keyboardState.IsKeyDown(Keys.S))
            {
                position.Y += movementSpeed * deltaTime;
            }
        }
    }
}
