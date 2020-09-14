using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game.Models
{
    class Bot : Man
    {
        public Bot(string name) : base(name)
        {

        }
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
