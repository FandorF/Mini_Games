using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games
{
   public class InputHandler
   {
        private readonly InputController _inputController;
        public InputHandler(InputController inputController)
        {
            _inputController = inputController;

            _inputController.Register('w', DrawText); //subscribe 
        }

        //public void Initialize()
        //{
        //    _inputController.Register('w', DrawText); //subscribe
        //}

        public void DrawText()
        {
            Console.WriteLine("Text");
        }

        public void Dispose()
        {
            _inputController.Unregister('w', DrawText); //unsubscribe
        }
    }
}
