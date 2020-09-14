using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game
{
    interface IAliveEntity
    {
        int Hp { get; }

        bool Alive { get; }

        void Damage();
        
    }
}
