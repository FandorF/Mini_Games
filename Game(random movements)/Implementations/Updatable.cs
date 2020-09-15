using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.ConsoleGame
{
    class Updatable : IUpdatable
    {
        private readonly List<IUpdatable> _updatablesObjects = new List<IUpdatable>();
        public Updatable(List<IUpdatable> updatablesObjects)
        {
            _updatablesObjects = updatablesObjects;
        }
        public void Update()
        {
            foreach(var updatableObject in _updatablesObjects)
            {
                updatableObject.Update();
            }
        }
    }
}
