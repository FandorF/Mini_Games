using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Mini_Games.ConsoleGame
{
    class Enemy : IMoveable
    {
        public Vector2 Position { get; private set; }
       
        public void SetPosition(Vector2 changedPos)
        {
            Position = changedPos;
            Console.WriteLine("Enemy changed position{0}",Position);
        }
    }
}
