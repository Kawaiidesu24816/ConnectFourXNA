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

        private static CellImage _emptyCell = new CellImage("empty");
        private static CellImage _blackCell = new CellImage("black");
        private static CellImage _redCell = new CellImage("red");

        #endregion

        public Cell(int rectangleX, int rectangleY)
        {
            _rectangleX = rectangleX;
            _rectangleY = rectangleY;

            _cellImage = _emptyCell;
        }

        #region Methods

        /// <summary>
        /// Loads all cell textures.
        /// </summary>
        /// <param name="contentManager">Manager to load textures with.</param>
        public static void LoadContent(ContentManager contentManager)
        {
            _emptyCell.LoadContent(contentManager);
            _blackCell.LoadContent(contentManager);
            _redCell.LoadContent(contentManager);
        }

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

    /// <summary>
    /// 
    /// </summary>
    class CellImage
    {
        private string _filePath;
        private Texture2D _texture;

        public CellImage(string filePath)
        {
            _filePath = filePath;
        }

        public void LoadContent(ContentManager contentManager)
        {
            _texture = contentManager.Load<Texture2D>(_filePath);
        }

        public void Draw(SpriteBatch spriteBatch, int rectangleX, int rectangleY)
        {
            spriteBatch.Draw(
                _texture, 
                new Rectangle(rectangleX, rectangleY, _texture.Width, _texture.Height), 
                Color.White);
        }
    }
}
