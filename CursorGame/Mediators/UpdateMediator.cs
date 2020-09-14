using System.Collections.Generic;

namespace Mini_Games.CursorGame
{
    class UpdateMediator
    {
        private readonly List<IUpdatable> _updatables;

        public UpdateMediator(params IUpdatable[] updatables)
        {
            _updatables = new List<IUpdatable>(updatables);
            //_updatables.AddRange(updatables);
        }
        //public UpdateMediator(List<IUpdatable> updatables)
        //{
        //    _updatables.AddRange(updatables);
        //}

        public void Update()
        {
            foreach(var entitie in _updatables)
            {
                entitie.CustomUpdate();
            }
        }
    }
}
