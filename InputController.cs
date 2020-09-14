using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games
{
    public class InputController
    {
        private Dictionary<char, Action> _subscribers;
        public InputController()
        {
            _subscribers = new Dictionary<char, Action>();
        }

        public void Register(char chKey, Action onEvent)
        {
            if (_subscribers.ContainsKey(chKey)) _subscribers[chKey] += onEvent;
            else _subscribers[chKey] = onEvent;
        }
        public void Unregister(char ch, Action onEvent)
        {
            _subscribers[ch] -= onEvent;
        }

        public void Update() //метод игровой логики.
        {
            if (!Console.KeyAvailable) return;

            var keyConsole = Console.ReadKey();
            char keyCh = keyConsole.KeyChar;
            _subscribers.TryGetValue(keyCh, out var handler);
            handler?.Invoke();


            //string hideResult = keyConsole.ToString();
            //if (keyConsole != null) 
            //hideResult.Replace(hideResult, "");



            //char[] chs = { keyCh };
            //string hideResult = new string(chs);
            //hideResult = hideResult.Replace(hideResult,"");


        }
    }
}
