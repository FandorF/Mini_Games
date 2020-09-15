using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Mini_Games.ConsoleGame
{
    interface IMoveable : IHavePosition
    {
        void SetPosition(Vector2 changedPos);
    }
}
