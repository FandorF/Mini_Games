using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.ConsoleGame
{
    class DamageController : IUpdatable
    {
        private readonly IPlayer _player;
        private readonly List<IHavePosition> _moveableObjects;

        public DamageController(List<IHavePosition> moveableObjects, IPlayer player)
        {
            _moveableObjects = moveableObjects;
            _player = player;
        }

        public void Update()
        {
            foreach(var moveableObject in _moveableObjects)
            {
                if (moveableObject == _player)
                    continue;

                if(moveableObject.Position == _player.Position)
                    _player.TakeDamage(1);
            }
        }
    }
}
