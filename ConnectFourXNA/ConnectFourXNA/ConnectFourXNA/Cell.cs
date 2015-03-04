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

        public Rectangle drawRectangle;
        public Texture2D tile;
        int x;
        int y;

        #endregion

        public Cell(int rectangleX, int rectangleY)
        {
            x = rectangleX;
            y = rectangleY;
            
        }

        #region Methods

        // LoadContent method assigns a sprite to a cell.
        public void LoadContent(string fileName, ContentManager contentManager)
        {
            
            tile = contentManager.Load<Texture2D>(fileName);
            drawRectangle = new Rectangle(x, y, tile.Width, tile.Height);
        }

        public void Update()
        {
            //will update the cell to change its state.
        }

        // Draw method draws a cell.
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tile, drawRectangle, Color.White);
        }

        #endregion

    }
}
