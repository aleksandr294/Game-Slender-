using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    /// <summary>
    /// Class for creating sprites
    /// </summary>
    public class SpriteCreater
    {
        /// <summary>
        /// The create method creates a sprite along the path that will be passed in the method parameters
        /// </summary>
        /// <param name="path_file">path to sprite</param>
        /// <returns>Created sprite on the given path</returns>
        public Sprite create(string path_file)
        {
            Texture2D texture = new Texture2D(355, 496, TextureFormat.ARGB32, false);
            byte[] file = File.ReadAllBytes(path_file);
            texture.LoadImage(file);
            Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            return sprite;
        }
    }

