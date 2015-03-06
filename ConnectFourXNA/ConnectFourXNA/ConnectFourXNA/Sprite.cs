using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectFourXNA
{
    public class Sprite
    {
        private string name;
        private Texture2D texture;

        public string Name { get { return name; } set { name = value; } }
        public Texture2D Texture { get { return texture; } }
        public int Width { get { return texture.Width; } }
        public int Height { get { return texture.Height; } }

        public Sprite(string name, Texture2D texture)
        {
            this.name = name;
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position, SpriteEffects effects)
        {
            if (effects.Centralize)
            {
                position.X -= texture.Width / 2;
                position.Y -= texture.Height / 2;
            }
            spriteBatch.Draw(texture, position, null, effects.Color, effects.Rotation, effects.Origin, effects.Scale, Microsoft.Xna.Framework.Graphics.SpriteEffects.None, 1f);
        }
        public Rectangle GetArea(Vector2 position, SpriteEffects effects)
        {
            if (effects.Centralize)
            {
                position.X -= Width / 2f;
                position.Y -= Height / 2f;
            }
            Point intPosition = new Point((int)position.X, (int)position.Y);
            return new Rectangle(intPosition.X, intPosition.Y, Width, Height);

        }
    }
    public class SpriteEffects
    {
        private float scale;
        private Color color;
        private float rotation;
        private Vector2 origin;
        private bool centralize;

        public float Scale { get { return scale; } set { scale = value; } }
        public Color Color { get { return color; } set { color = value; } }
        public float Rotation { get { return rotation; } set { rotation = value; } }
        public Vector2 Origin { get { return origin; } set { origin = value; } }
        public bool Centralize { get { return centralize; } set { centralize = value; } }


        public SpriteEffects()
        {
            scale = 1f;
            color = Color.White;
            rotation = 0f;
            origin = Vector2.Zero;
            centralize = true;
        }
    }
}
