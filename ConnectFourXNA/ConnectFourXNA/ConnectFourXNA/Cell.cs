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

    /// <summary>
    /// Holds and draws a single cell texture.
    /// </summary>
    class CellImage
    {
        #region public

        public static CellImage EmptyCell
        {
            get
            {
                return _emptyCell;
            }
        }
        public static CellImage BlackCell
        {
            get
            {
                return _blackCell;
            }
        }
        public static CellImage RedCell
        {
            get
            {
                return _redCell;
            }
        }

        /// <summary>
        /// Loads all cell textures.
        /// </summary>
        /// <param name="contentManager">Manager to load textures with.</param>
        public static void LoadContent(ContentManager contentManager)
        {
            EmptyCell.LoadTexture(contentManager);
            BlackCell.LoadTexture(contentManager);
            RedCell.LoadTexture(contentManager);
        }

        /// <summary>
        /// Draws cell at given coordinates.
        /// </summary>
        /// <param name="spriteBatch">SpriteBatch to draw in.</param>
        /// <param name="rectangleX">X coordinate.</param>
        /// <param name="rectangleY">Y coordinate.</param>
        public void Draw(SpriteBatch spriteBatch, int rectangleX, int rectangleY)
        {
            spriteBatch.Draw(
                _texture,
                new Rectangle(rectangleX, rectangleY, _texture.Width, _texture.Height),
                Color.White);
        }

        #endregion

        #region private
        
        private string _filePath;
        private Texture2D _texture;

        private static CellImage _emptyCell = new CellImage("empty");
        private static CellImage _blackCell = new CellImage("black");
        private static CellImage _redCell = new CellImage("red");

        private CellImage(string filePath)
        {
            _filePath = filePath;
        }

        private void LoadTexture(ContentManager contentManager)
        {
            _texture = contentManager.Load<Texture2D>(_filePath);
        }

        #endregion
    }
}
