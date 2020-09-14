using System;

namespace Mini_Games.CursorGame
{
    interface IPlayerModel
    {
        event Action PositionChanged;
        (int,int) Position { get; set; }
    }
}
