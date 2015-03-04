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

        int columnNumber;
        int rowNumber;
        int tileWidth;
        int tileHeight;
        Cell[,] cells;

        #endregion

        public Board(int COLUMN_NUMBER, int ROW_NUMBER, int TILE_WIDTH, int TILE_HEIGHT)
        {
            columnNumber = COLUMN_NUMBER;
            rowNumber = ROW_NUMBER;
            tileWidth = TILE_WIDTH;
            tileHeight = TILE_HEIGHT;
            cells = new Cell[columnNumber, rowNumber];

        }
        #region Methods

        // Initialise method creates 42 cells
        public void Initialise()
        {
            for (int i = 0; i < columnNumber; i++)
            {
                for (int j = 0; j < rowNumber; j++)
                {
                    int x = tileWidth * i;
                    int y = tileHeight * j;
                    cells[i, j] = new Cell(x, y);
                }
            }
        }

        public void Update()
        {
            // Will update the every cell to change its state.
        }

        // LoadContent method assignes a sprite for every cell using cell.LoadContent method.
        // ---> TO DO: Create a system to assign right sprite for diffrent state of cell using "fileName" variable instead of "empty" string. <---
        public void LoadContent(ContentManager contentManager)
        {
            for (int i = 0; i < columnNumber; i++)
            {
                for (int j = 0; j < rowNumber; j++)
                {
                    cells[i, j].LoadContent("black", contentManager);
                }
            }
        }

        // Draw method draws 42 cells using cell.Draw method. 
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < columnNumber; i++)
            {
                for (int j = 0; j < rowNumber; j++)
                {
                    cells[i, j].Draw(spriteBatch);
                }
            }
        }
        #endregion
    }
}
