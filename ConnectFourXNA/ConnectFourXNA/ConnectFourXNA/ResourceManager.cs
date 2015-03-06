using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConnectFourXNA
{
    class ResourceManager
    {
        private Sprite nullSprite;// = new Sprite("nullSprite")
        private List<Sprite> sprites = new List<Sprite>();

        public ResourceManager(ContentManager contentManager)
        {
            string[] filePaths = Directory.GetFiles("Content\\Sprites", "*.xnb", SearchOption.AllDirectories);

            for (int i = 0; i < filePaths.Length; i++)
            {
                string filePath = filePaths[i].Remove(filePaths[i].Length - 4).Remove(0, 8); //Удаляем "\Content" и ".xnb" из пути. Мы точно знаем, что путь начинается с "\Content" и заканчивается ".xnb"
                sprites.Add(new Sprite(filePath.Remove(0, 8).ToLower(), contentManager.Load<Texture2D>(filePath)));
            }
            nullSprite = GetSprite("nulltexture");
            if (nullSprite == null)
                throw new FileNotFoundException("Файл nullSprite не обнаружен, ResoureManager может работать с ошибками");
        }

        public Sprite GetSprite(string name)
        {
            name = name.ToLower();
            foreach (Sprite sprite in sprites)
                if (sprite.Name == name)
                    return sprite;
            return nullSprite;
        }

    }
}
