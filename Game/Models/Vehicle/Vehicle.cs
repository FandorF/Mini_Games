using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game.Models
{
    abstract class Vehicle : IMovable
    {
        private readonly float _speed;
        public float Speed { get => _speed; set => value = _speed; }
        private readonly (float, float, float) _direction;
        public (float, float, float) Direction { get => _direction; set => value = _direction; }
        public void Move()
        {
            //
        }
    }
}
