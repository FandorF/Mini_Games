using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleGame
{
    class Player : IPlayer
    {
        public int Hp { get; private set; }
        public bool Alive => Hp >= 1;
        public Vector2 Position { get; private set; }

        public Player(int hp)
        {
            Hp = hp;
        }
       
        public void SetPosition(Vector2 changedPos)
        {
            Position = changedPos;
            Console.WriteLine("Player changed position:{0}",Position);
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp < 0)
                Hp = 0;
            Console.WriteLine("Player take damage, Hp value:{0}", Hp);
        }

       
    }
}
