using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace summer2023StarDogMobyGreenNebulaRush
{
    internal class GameController
    {
        public List<Asteroid> astroidsList = new List<Asteroid>();
        private const double SPAWN_TIMER_DURATION = 2.0;
        public double spawnTimer = SPAWN_TIMER_DURATION;
        public void Update(GameTime gameTime)
        {
            // Whenever time reaches zero generate an Asteroid
            spawnTimer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (spawnTimer < 0)
            {
                astroidsList.Add(new Asteroid(100));
                spawnTimer = SPAWN_TIMER_DURATION;
            }
        }
    }
}
