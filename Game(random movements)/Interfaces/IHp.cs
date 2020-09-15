using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.ConsoleGame
{
    interface IHp
    {
        int Hp { get; }
        bool Alive { get; }
        void TakeDamage(int damage);
    }
}
