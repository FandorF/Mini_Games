using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game
{
    class UpdateMediator
    {
        private readonly List<IUpdatable> _updatables;

        public UpdateMediator(params IUpdatable[] updatables)
        {
            _updatables = new List<IUpdatable>(updatables);
            //_updatables.AddRange(updatables);
        }
       

        public void Update()
        {
            foreach (var entity in _updatables)
            {
                entity.Update();
            }
        }
    }
}
