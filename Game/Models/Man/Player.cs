using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game.Models
{
    class Player : Man
    {
        private byte _health;
        private int _playerLvl;
        public int PlayerLvl { get => _playerLvl; set => value = _playerLvl; }
        public Player(string name, int lvl) : base(name)
        {
            _playerLvl = lvl;
        }

        public override int Health { get => _health; set => value =_health; }

        public override void Move()
        {
            //Player movement code
        }
    }
}