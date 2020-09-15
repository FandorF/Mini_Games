using System.Collections.Generic;

namespace Mini_Games.CursorGame
{
    class DisposeMediator
    {
        private readonly List<IDisposable>  _disposables;

        public DisposeMediator(List<IDisposable> disposables)
        {
            _disposables = new List<IDisposable>(disposables);
        }

        public void Dispose()
        {
            foreach(var entitie in _disposables)
            {
                entitie.Dispose();
            }
        }
    }
}
