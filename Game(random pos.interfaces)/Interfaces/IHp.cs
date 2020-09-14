using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    interface IHp
    {
        int Hp { get; }
        bool Alive { get; }
        void TakeDamage(int damage);
    }
}
