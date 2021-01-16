using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpriteFontPlus.Samples.TtfBaking.MonoGame.SpriteFontPlus;

namespace SpriteFontPlus.Samples.TtfBaking.MonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private const int FontBitmapWidth = 1024;
        private const int FontBitmapHeight = 1024;

        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        private SpriteFont   _fontChinese;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            // Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 480;
            _graphics.ApplyChanges();
            Window.Title = "字体测试";
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            _fontChinese = TtfFontBaker.Bake(@"Fonts\SourceHanSansCN-Normal.ttf", 20, 3 * 1024, 3 * 1024, new[]
            {
                new CharacterRange(' '),
                CharacterRange.BasicLatin,
                CharacterRange.Chinese,
                CharacterRange.ChineseSupplement,
                CharacterRange.ChineseSymbol0,
                CharacterRange.ChineseSymbol1,
                CharacterRange.ChineseSymbol2,
                CharacterRange.ChineseSymbol3,
                CharacterRange.ChineseSymbol4,
                CharacterRange.ChineseSymbol5,
                CharacterRange.ChineseSymbol6,
                CharacterRange.ChineseSymbol7,
                CharacterRange.ChineseSymbol8,
                CharacterRange.ChineseSymbol9,
                CharacterRange.ChineseSymbol10,
                CharacterRange.ChineseSymbol11,
                CharacterRange.ChineseSymbol12,
                CharacterRange.ChineseSymbol13,
                CharacterRange.ChineseSymbol14,
                CharacterRange.ChineseSymbol15,
                CharacterRange.ChineseSymbol16,
                CharacterRange.ChineseSymbol17,
                CharacterRange.ChineseSymbol18,
                CharacterRange.ChineseSymbol19,
                CharacterRange.ChineseSymbol20,
                CharacterRange.ChineseSymbol21,
                CharacterRange.ChineseSymbol22,
                CharacterRange.ChineseSymbol23,
                CharacterRange.ChineseSymbol24,
                CharacterRange.ChineseSymbol25,
                CharacterRange.ChineseSymbol26,
                CharacterRange.ChineseSymbol27,
                CharacterRange.ChineseSymbol28,
            }).CreateSpriteFont(GraphicsDevice);
            GC.Collect();
            base.LoadContent();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // Render some text
            _spriteBatch.DrawString(_fontChinese, "《这是绘制的一段中文!》", Vector2.One, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}