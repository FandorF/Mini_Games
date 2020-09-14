using System;

namespace Mini_Games.CursorGame
{
    class PlayerDrawingController : IDisposable, IInitialize
    {
        private readonly IPlayerModel _playerModel;

        public PlayerDrawingController(IPlayerModel playerModel)
        {
            _playerModel = playerModel;
            _playerModel.PositionChanged += DrawPos;
        }

        public void DrawPos()
        {
            Console.Clear();
            Console.SetCursorPosition(_playerModel.Position.Item1, _playerModel.Position.Item2);
            Console.Write('+');
        }

        public void Initialize()
        {
            DrawPos();
        }

        public void Dispose()
        {
            _playerModel.PositionChanged -= DrawPos;
        }
    }
}
