using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.CursorGame
{
    class PlayerModel : IPlayerModel
    {
        public event Action PositionChanged;

        private (int, int) _position;
        public (int, int) Position
        {
            get => _position;
            set
            {
                if (value != _position)
                {
                    _position = value;
                    PositionChanged.Invoke();
                }
            }
        }
    }
}
