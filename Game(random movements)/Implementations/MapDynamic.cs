using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.ConsoleGame
{
    class MapDynamic : IMap, IUpdatable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Random _random;
                                                           
        public MapDynamic(int width, int height)
        {
            _random = new Random();
            Width = width;
            Height = height;
        }

        public void Update()
        {
            Width = _random.Next(minValue:5, maxValue:15);
            Height = _random.Next(minValue: 5, maxValue: 15);
        }
    }
}
