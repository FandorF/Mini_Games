using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games
{
    class EndOfApplication
    {
        private readonly InputController _inputController;
        public bool endApp;
        public EndOfApplication(InputController inputController)
        {
            _inputController = inputController;
            _inputController.Register('q', EndApp);
        }

        public void EndApp()
        {
            endApp = true;
        }

        public void Dispose()
        {
            _inputController.Unregister('q', EndApp);
        }
    }
}
