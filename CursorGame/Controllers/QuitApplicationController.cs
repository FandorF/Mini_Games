namespace Mini_Games.CursorGame
{
    class QuitApplicationController : IDisposable
    {
       public bool EndApp { get; set; }

       private readonly InputController _inputController;
       
       public QuitApplicationController(InputController inputController)
       {
          _inputController = inputController;
          _inputController.Register('q', QuitApp);
       }
    
       public void QuitApp()
       {
          EndApp = true;
       }
        public void Dispose()
        {
            _inputController.Register('q', QuitApp);
        }
    }
}
