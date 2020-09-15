using System.Collections.Generic;

namespace Mini_Games.CursorGame
{
    class Program
    {
        private static void Main(string[] agrs)
        {
            var playerModel = new PlayerModel();//модель
            var playerDrawingController = new PlayerDrawingController(playerModel);//отрисовка позиции
                                                                                   // var initializeMediator = new InitializeMediator(playerDrawingController);
            var inpController = new InputController();
            var movementController = new MovementController(inpController, playerModel);//движение

            var quitApp = new QuitApplicationController(inpController);
            var updateMediator = new UpdateMediator(new List<IUpdatable> { inpController });
            var disposeMediator = new DisposeMediator(new List<IDisposable> { quitApp, movementController });

            var initializeMediator = new InitializeMediator(new List<IInitialize> { playerDrawingController });

            initializeMediator.Initialize();

            while (!quitApp.EndApp)
            {
                updateMediator.Update();
            }

            disposeMediator.Dispose();
        }
    }
}
