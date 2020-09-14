using System;

namespace Mini_Games.CursorGame
{
    class MovementController : IDisposable
    {
        private readonly InputController _inputController;
        private readonly IPlayerModel _iplayerModel;
        private int _x, _y;

        public MovementController(InputController inputController, IPlayerModel iplayerModel)
        {
            _inputController = inputController;
            _iplayerModel = iplayerModel;

            _inputController.Register('w', CrossUp);
            _inputController.Register('s', CrossDown);
            _inputController.Register('a', CrossLeft);
            _inputController.Register('d', CrossRight);
        }

        public void CrossUp()
        {
            (_x, _y) = _iplayerModel.Position;
            _iplayerModel.Position = ClampPos(_x, _y-1);
        }

        public void CrossDown()
        {
            (_x, _y) = _iplayerModel.Position;
            _iplayerModel.Position = ClampPos(_x, _y+1);
        }

        public void CrossRight()
        {
             (_x, _y) = _iplayerModel.Position;
            _iplayerModel.Position = ClampPos(_x+1, _y);
        }

        public void CrossLeft()
        {
            (_x, _y) = _iplayerModel.Position;
            _iplayerModel.Position = ClampPos(_x-1, _y);
        }

        public (int x, int y) ClampPos(int x, int y)
        {
            if (x < 0)
                x = 0;
            else if (x >= Console.BufferWidth)
                x = Console.BufferWidth - 1;

            if (y < 0)
                y = 0;
            else if (y >= Console.BufferHeight)
                y = Console.BufferHeight - 1;

            return (x, y);
        }

        public void Dispose()
        {
            _inputController.Unregister('w', CrossUp);
            _inputController.Unregister('s', CrossDown);
            _inputController.Unregister('a', CrossLeft);
            _inputController.Unregister('d', CrossRight);
        }
    }
}
