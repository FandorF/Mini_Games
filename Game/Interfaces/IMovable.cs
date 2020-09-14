using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game
{
    interface IMovable
    {
        float Speed { get; set; }
        (float, float, float) Direction { get; set; }

        void Move();

    }

    
}
