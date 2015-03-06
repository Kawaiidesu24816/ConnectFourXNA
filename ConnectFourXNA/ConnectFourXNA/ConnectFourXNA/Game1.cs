using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ConnectFourXNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Board board;

        //constants for tile size and cells number
        const int TILE_WIDTH = 128;
        const int TILE_HEIGHT = 128;
        const int COLUMN_NUMBER = 7;
        const int ROW_NUMBER = 6;
        const int WINDOW_WIDTH = TILE_WIDTH * COLUMN_NUMBER; // 128 * 7 = 896
        const int WINDOW_HEIGHT = TILE_HEIGHT * ROW_NUMBER; // 128 * 6 = 768

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // set resolution
            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
        }
        protected override void Initialize()
        {
            Services.AddService(typeof(ResourceManager), new ResourceManager(Content)); //Load sprites

            board = new Board(this, COLUMN_NUMBER, ROW_NUMBER, TILE_WIDTH, TILE_HEIGHT);

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Services.AddService(typeof(SpriteBatch), spriteBatch);                      //Setup drawing stuff
        }
        protected override void UnloadContent()
        {
            
        }
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);

            spriteBatch.Begin();

            base.Draw(gameTime);

            spriteBatch.End();
        }
    }
}
