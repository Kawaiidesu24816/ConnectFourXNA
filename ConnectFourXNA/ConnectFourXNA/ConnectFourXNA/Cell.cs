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

        private CellImage _cellImage;
        private int _rectangleX, _rectangleY;

        #endregion

        public Cell(int rectangleX, int rectangleY)
        {
            _rectangleX = rectangleX;
            _rectangleY = rectangleY;

            _cellImage = CellImage.EmptyCell;
        }

        #region Methods

        public void Update()
        {
            //will update the cell to change its state.
        }

        // Draw method draws a cell.
        public void Draw(SpriteBatch spriteBatch)
        {
            _cellImage.Draw(spriteBatch, _rectangleX, _rectangleY);
        }

        #endregion

    }
}
