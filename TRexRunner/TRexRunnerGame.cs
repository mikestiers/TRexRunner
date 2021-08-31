using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TRexRunner.Graphics;

namespace TRexRunner
{
    public class TRexRunnerGame : Game
    {
        private const string ASSET_NAME_SPRITESHEET = "TrexSpriteSheet";
        private const string ASSET_NAME_SFX_HIT = "TrexRunner_Content_hit";
        private const string ASSET_NAME_SFX_SCORE_REACHED = "TrexRunner_Content_score-reached";
        private const string ASSET_NAME_SFX_BUTTON_PRESS = "TrexRunner_Content_button-press";

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SoundEffect _sfxHit;
        private SoundEffect _sfxScoreReached;
        private SoundEffect _sfxButtonPress;

        private Texture2D _spriteSheetTexture;

        public TRexRunnerGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _sfxHit = Content.Load<SoundEffect>(ASSET_NAME_SFX_HIT);
            _sfxScoreReached = Content.Load<SoundEffect>(ASSET_NAME_SFX_SCORE_REACHED);
            _sfxButtonPress = Content.Load<SoundEffect>(ASSET_NAME_SFX_BUTTON_PRESS);

            _spriteSheetTexture = Content.Load<Texture2D>(ASSET_NAME_SPRITESHEET);
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

            _spriteBatch.Begin();

            _spriteBatch.Draw(_spriteSheetTexture, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(_spriteSheetTexture, new Vector2(10, 80), new Rectangle(848, 0, 44, 52), Color.White);
            Sprite trexSprite = new Sprite(_spriteSheetTexture, 848, 0, 44, 52);
            trexSprite.Draw(_spriteBatch, new Vector2(40, 160));

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
