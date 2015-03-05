using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Cell class create a cell  
    /// </summary>
    class Cell
    {
        #region Fields

        private Rectangle _drawRectangle;
        private Texture2D _tile;

        private static string EmptyTextureFilePath = "empty";
        private static string BlackTextureFilePath = "black";
        private static string RedTextureFilePath = "red";

        private static Texture2D _emptyTexture;
        private static Texture2D _blackTexture;
        private static Texture2D _redTexture;

        #endregion

        public Cell(int rectangleX, int rectangleY)
        {
            _drawRectangle = new Rectangle(rectangleX, rectangleY, 0, 0);
        }

        #region Methods

        // LoadContent method assigns a sprite to a cell.
        public void LoadContent()
        {
            
            _tile = _emptyTexture;
            _drawRectangle.Width = _tile.Width;
            _drawRectangle.Height = _tile.Height;
        }

        /// <summary>
        /// Loads all cell textures.
        /// </summary>
        /// <param name="contentManager">Manager to load textures with.</param>
        public static void LoadContent(ContentManager contentManager)
        {
            _emptyTexture = contentManager.Load<Texture2D>(EmptyTextureFilePath);
            _blackTexture = contentManager.Load<Texture2D>(BlackTextureFilePath);
            _redTexture = contentManager.Load<Texture2D>(RedTextureFilePath);
        }

        public void Update()
        {
            //will update the cell to change its state.
        }

        // Draw method draws a cell.
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_tile, _drawRectangle, Color.White);
        }

        #endregion

    }
}
