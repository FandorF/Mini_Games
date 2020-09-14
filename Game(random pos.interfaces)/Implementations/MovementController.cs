using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ConsoleGame
{
    class MovementController : IUpdatable
    {
        private readonly IMap _map;
        private readonly List<IMoveable> _moveableObjects;
        private readonly Random _random;

        private readonly Vector2[] _randomPosValues =
        {
            new Vector2(0,1),
            new Vector2(0,-1),
            new Vector2(1,0),
            new Vector2(-1,0)
        };

        public MovementController(List<IMoveable> moveableObjects,IMap iMap)
        {
            _map = iMap;
            _random = new Random();
            _moveableObjects = moveableObjects;
        }

        public void Update()
        {
            foreach (var moveableObject in _moveableObjects)
            {
                var newRandomPosition = GetNewRandomPosition(moveableObject);
                moveableObject.SetPosition(newRandomPosition);
            }
        }

        private Vector2 GetNewRandomPosition(IMoveable moveableObject)
        {
            while (true)
            {
                var rndPos = _randomPosValues[_random.Next(0, _randomPosValues.Length)];
                var newRandomPosition = moveableObject.Position + rndPos;

                if (newRandomPosition.X < _map.Width && newRandomPosition.X >= 0 && newRandomPosition.Y < _map.Height && newRandomPosition.Y >= 0)
                    return newRandomPosition;
            }
        }
    }
}
