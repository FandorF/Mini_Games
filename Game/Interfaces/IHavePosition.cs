using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Mini_Games.Game
{
    interface IHavePosition
    {
        Vector2 Position { get; set; }

        void SetPosition(Vector2 pos);
       
    }
}
