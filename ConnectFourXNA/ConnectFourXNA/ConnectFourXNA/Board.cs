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
    /// Board class controls (load, draws, update etc.) all cells using Cell class.
    /// </summary>
    class Board
    {
        #region Fields 

        private int _columnNumber;
        private int _rowNumber;
        private int _tileWidth;
        private int _tileHeight;
        Cell[,] cells;

        #endregion

        public Board(int columnNumber, int rowNumber, int tileWidth, int tileHeight)
        {
            _columnNumber = columnNumber;
            _rowNumber = rowNumber;
            _tileWidth = tileWidth;
            _tileHeight = tileHeight;

            cells = new Cell[_columnNumber, _rowNumber];

        }
        #region Methods

        // Initialise method creates 42 cells
        public void Initialise()
        {
            for (int i = 0; i < _columnNumber; i++)
            {
                for (int j = 0; j < _rowNumber; j++)
                {
                    int x = _tileWidth * i;
                    int y = _tileHeight * j;
                    cells[i, j] = new Cell(x, y);
                }
            }
        }

        public void Update()
        {
            // Will update the every cell to change its state.
        }

        // LoadContent method assignes a sprite for every cell using cell.LoadContent method.
        public void LoadContent(ContentManager contentManager)
        {
            for (int i = 0; i < _columnNumber; i++)
            {
                for (int j = 0; j < _rowNumber; j++)
                {
                    cells[i, j].LoadContent(Cell.BlackTextureFilePath, contentManager);
                }
            }
        }

        // Draw method draws 42 cells using cell.Draw method. 
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < _columnNumber; i++)
            {
                for (int j = 0; j < _rowNumber; j++)
                {
                    cells[i, j].Draw(spriteBatch);
                }
            }
        }
        #endregion
    }
}
