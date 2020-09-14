using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game.Models
{
    abstract class Man : IMovable
    {
        public string Name { get; set; }
        public Man(string name)
        {
            Name = name;
        }

        #region IMovable implement
        private readonly float _speed;
        public float Speed { get => _speed; set => value = _speed; }

        private readonly (float,float,float) _direction;
        public (float, float, float) Direction { get => _direction; set => value = _direction; }

        public abstract void Move();
        #endregion 

        public abstract int Health { get; set; } 
    }
}
