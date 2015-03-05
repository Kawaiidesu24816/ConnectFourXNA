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

        public static string EmptyTextureFilePath = "empty";
        public static string BlackTextureFilePath = "black";
        public static string RedTextureFilePath = "red";

        #endregion

        public Cell(int rectangleX, int rectangleY)
        {
            _drawRectangle = new Rectangle(rectangleX, rectangleY, 0, 0);
        }

        #region Methods

        // LoadContent method assigns a sprite to a cell.
        public void LoadContent(string fileName, ContentManager contentManager)
        {
            
            _tile = contentManager.Load<Texture2D>(fileName);
            _drawRectangle.Width = _tile.Width;
            _drawRectangle.Height = _tile.Height;
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
