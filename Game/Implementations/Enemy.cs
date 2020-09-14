using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Mini_Games.Game
{
    class Enemy : IPlayer
    {
        public int Hp { get => _hp; set => value = _hp; }
        public Vector2 Position { get; set; }
        public bool Alive => _hp > 0;
      
        private int _hp;
        public Enemy(int hp)
        {
            _hp = hp;
        }

        public void SetPosition(Vector2 pos)
        {
            Position = pos;
        }
        public void Damage()
        {
            _hp -= 1;
        }
    }
}
