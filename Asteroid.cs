using Microsoft.Xna.Framework;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace summer2023StarDogMobyGreenNebulaRush
{
    class Asteroid
    {
        public Vector2 position = new Vector2(500, 500);
        public float speed;
        public int radius;

        public void Update(GameTime gameTime)
        {
            float delatTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * delatTime;
        }

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
        }
    }
}
