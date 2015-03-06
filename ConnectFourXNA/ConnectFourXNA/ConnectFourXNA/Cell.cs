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
    enum CellState { Empty, Black, Red }
    /// <summary>
    /// Cell class create a cell  
    /// </summary>
    class Cell : DrawableGameComponent
    {
        #region Fields

        private CellState state;
        private Sprite sprite;
        private SpriteEffects spriteEffects;
        private Vector2 position;

        
        public Sprite Sprite { get { return sprite; } }
        public SpriteEffects SpriteEffects { get { return spriteEffects; } }
        public CellState State
        {
            get { return state; }
            set
            {
                state = value;
                ResourceManager resources = (ResourceManager)Game.Services.GetService(typeof(ResourceManager));
                string test = state.ToString();
                sprite = resources.GetSprite(state.ToString());
            }
        }

        #endregion

        public Cell(Game1 game, Vector2 position)
            :base(game)
        {
            this.position = position;

            State = CellState.Empty;
            spriteEffects = new SpriteEffects();

            game.Components.Add(this);
        }

        #region Methods

        public override void Update(GameTime gameTime)
        {
            //will update the cell to change its state.
        }

        // Draw method draws a cell.
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = (SpriteBatch)Game.Services.GetService(typeof(SpriteBatch));
            Sprite.Draw(spriteBatch, position, spriteEffects);
        }
        #endregion

    }
}
