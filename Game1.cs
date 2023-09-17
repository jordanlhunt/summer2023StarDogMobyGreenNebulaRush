using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace summer2023StarDogMobyGreenNebulaRush
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D shipTexture;
        Texture2D asteriodTexture;
        Texture2D backgroundTexture;
        SpriteFont timerFont;
        SpriteFont spaceFont;
        Player player = new Player();
        Asteroid asteroid = new Asteroid(200);
        GameController gameController = new GameController();
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 576;

        }
        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            shipTexture = Content.Load<Texture2D>("PlayerShip");
            asteriodTexture = Content.Load<Texture2D>("meteorSmall");
            backgroundTexture = Content.Load<Texture2D>("Background");
            spaceFont = Content.Load<SpriteFont>("SpaceFont");
            timerFont = Content.Load<SpriteFont>("TimerFont");
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            player.Update(gameTime);
            asteroid.Update(gameTime);
            gameController.Update(gameTime);
            foreach (Asteroid gameControllerAsteroid in gameController.astroidsList)
            {
                gameControllerAsteroid.Update(gameTime);
            }
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, Vector2.Zero, Color.White);
            _spriteBatch.Draw(shipTexture, new Vector2(player.position.X - (shipTexture.Width / 2), player.position.Y - (shipTexture.Height) / 2), Color.White);
            _spriteBatch.Draw(asteriodTexture, new Vector2(asteroid.position.X - (asteriodTexture.Width / 2), asteroid.position.Y - (asteriodTexture.Height / 2)), Color.White);

            foreach (Asteroid gameControllerAsteroid in gameController.astroidsList)
            {
                _spriteBatch.Draw(asteriodTexture, new Vector2(gameControllerAsteroid.position.X - (asteriodTexture.Width / 2), gameControllerAsteroid.position.Y - (asteriodTexture.Height / 2)), Color.White); ;
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}