using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    class Map : IMap
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
