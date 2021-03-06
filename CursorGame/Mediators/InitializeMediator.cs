﻿using System.Collections.Generic;

namespace Mini_Games.CursorGame
{
    class InitializeMediator
    {
        private readonly List<IInitialize> _initializes;

        public InitializeMediator(List<IInitialize> initializes)
        {
           _initializes = new List<IInitialize>(initializes);
        }

        public void Initialize()
        {
           foreach(var init in _initializes)
           {
                init.Initialize();
           }
        }
    }
}
