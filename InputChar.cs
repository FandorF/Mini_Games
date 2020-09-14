using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games
{
    //delegate void InputHandler(string inputChar);
    //class Program
    //{
    //    private static void Main(string[] agrs)
    //    {
    //        var inputController = new InputController();
    //        var myInputHandler = new MyInputHandler(inputController);
    //        var endOfApp = new EndOfApp(inputController);

    //        while (!endOfApp.endApp)
    //        {
    //            inputController.Update();
    //        }
    //    }
    //}

    public class MyInputHandler2
    {
        private readonly string _message;
        private readonly char _keyChar;
        private readonly InputController _inputController;
        public MyInputHandler2(string message, char ch, InputController inputController)
        {
            _inputController = inputController;
            _message = message;
            _keyChar = ch;

            inputController.Register(_keyChar,ShowMessage);
        }

        public void ShowMessage()
        {
            Console.WriteLine(_message);
        }

        public void Dispose()
        {
            _inputController.Unregister(_keyChar, ShowMessage);
        }
    }
}
