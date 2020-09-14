using System;
using System.Collections.Generic;

namespace Mini_Games.CursorGame
{
    class InputController : IUpdatable
    {
        private readonly Dictionary<char, Action> _subscribers;

        public InputController()
        {
            _subscribers = new Dictionary<char, Action>();
        }

        public void Register(char ch, Action onEvent)
        {
            if (_subscribers.ContainsKey(ch)) _subscribers[ch] += onEvent;
            else _subscribers[ch] = onEvent;
        }

        public void Unregister(char ch, Action onEvent)
        {
            _subscribers[ch] -= onEvent;
        }

        public void CustomUpdate()
        {
            var ch = Console.ReadKey(true);
            char keyCh = ch.KeyChar;
            _subscribers.TryGetValue(keyCh, out var handler);
            handler?.Invoke();
        }
    }
}
