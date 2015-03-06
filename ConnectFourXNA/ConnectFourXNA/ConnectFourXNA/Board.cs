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

        public Board(Game1 game, int columnNumber, int rowNumber, int tileWidth, int tileHeight)
        {
            _columnNumber = columnNumber;
            _rowNumber = rowNumber;
            _tileWidth = tileWidth;
            _tileHeight = tileHeight;

            cells = new Cell[_columnNumber, _rowNumber];

            for (int i = 0; i < _columnNumber; i++)
            {
                for (int j = 0; j < _rowNumber; j++)
                {
                    float x = _tileWidth * i + tileWidth / 2f;
                    float y = _tileHeight * j + tileWidth / 2f;
                    cells[i, j] = new Cell(game, new Vector2(x, y));
                }
            }

        }
        #region Methods
        /* Инициализация не вызывает после метода Initialize в Game, поэтому мы переносим всё в конструктор
        // Initialize method creates 42 cells
        public void Initialize()
        {
            
        }
        */
        public void Update(GameTime gameTime)
        {
            // Will update the every cell to change its state.
        }

        #endregion
    }
}
