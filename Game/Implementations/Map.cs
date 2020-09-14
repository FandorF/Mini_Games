using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game
{
    class Map : IMap
    {
        public int Width { get => _width; set => value = _width; }
        public int Height { get => _height; set => value = _height; }

        private int _width;
        private int _height;
        public Map(int width, int height)
        {
            _width = width;
            _height = height;
        }
    }
}
