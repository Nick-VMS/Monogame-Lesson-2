using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2
{
    public class Game1 : Game
    {

        Texture2D rectangleTexture, circleTexture;
        Rectangle faceRect, mouthRect, eyeOneRect, eyeTwoRect, eyeOnePupilRect, eyeTwoPupilRect;
        SpriteFont titleFont;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Face Drawing";
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions

            faceRect = new Rectangle(300, 150, 200, 200); // Located at (300,150), 200 wide, 200 high
            eyeOneRect = new Rectangle(350, 200, 40, 40);
            eyeTwoRect = new Rectangle(415, 200, 40, 40);
            eyeOnePupilRect = new Rectangle(370, 220, 10, 10);
            eyeTwoPupilRect = new Rectangle(435, 220, 10, 10);
            mouthRect = new Rectangle(350, 275, 100, 30);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("Text");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            
            _spriteBatch.Draw(circleTexture,faceRect, Color.Yellow);
            _spriteBatch.Draw(circleTexture, eyeOneRect, Color.White);
            _spriteBatch.Draw(circleTexture, eyeTwoRect, Color.White);
            _spriteBatch.Draw(rectangleTexture, mouthRect, Color.Red);
            _spriteBatch.Draw(circleTexture, eyeOnePupilRect, Color.Black);
            _spriteBatch.Draw(circleTexture, eyeTwoPupilRect, Color.Black);
            _spriteBatch.DrawString(titleFont, "SMILEY FACE, by  Nick VMS. ", new Vector2(10, 10), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}